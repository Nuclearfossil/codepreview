using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SharpShell.SharpPreviewHandler;
using System.Reflection;

namespace CodePreview
{
    public partial class CodePreviewControl : PreviewHandlerControl
    {
        private string m_filename;
        private bool m_dirty;
        private bool m_dontload;

        private string GetAssemblyDirectory()
        {
            string codeBase = Assembly.GetExecutingAssembly().CodeBase;
            UriBuilder uri = new UriBuilder(codeBase);
            string path = Uri.UnescapeDataString(uri.Path);
            return Path.GetDirectoryName(path);
        }
        public CodePreviewControl()
        {
            InitializeComponent();
            string settingsFile = string.Format("{0}\\{1}\\", GetAssemblyDirectory(), "settings");
            try
            {
                sctEditor.ConfigurationManager.CustomLocation = settingsFile;
                m_dontload = false;
            }
            catch (Exception ex)
            {
                sctEditor.Text = string.Format("Exception: {0} \nloading file {1}", ex.Message, sctEditor.ConfigurationManager.CustomLocation);
                m_dontload = true;
            }
        }

        public void DoPreview(string selectedFilePath)
        {
            if (!m_dontload)
            {
                m_filename = selectedFilePath;
                try
                {
                    if (selectedFilePath.EndsWith(".c") || selectedFilePath.EndsWith(".h") || selectedFilePath.EndsWith(".cpp") || selectedFilePath.EndsWith(".hpp"))
                        sctEditor.ConfigurationManager.Language = "cpp";
                    else if (selectedFilePath.EndsWith(".cs"))
                        sctEditor.ConfigurationManager.Language = "cs";
                    else if (selectedFilePath.EndsWith(".py"))
                        sctEditor.ConfigurationManager.Language = "python";
                    else if (selectedFilePath.EndsWith(".xml"))
                        sctEditor.ConfigurationManager.Language = "xml";
                    else if (selectedFilePath.EndsWith(".bat") || selectedFilePath.EndsWith(".cmd"))
                        sctEditor.ConfigurationManager.Language = "batch";
                    sctEditor.Text = System.IO.File.ReadAllText(selectedFilePath);
                    m_dirty = false;
                }
                catch (Exception ex)
                {
                    sctEditor.Text = string.Format("Exception: {0} \nloading file {1}", ex.Message, sctEditor.ConfigurationManager.CustomLocation);
                    m_dontload = true;
                }
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (m_dirty && !m_dontload)
            {
                try
                {
                    System.IO.File.WriteAllText(m_filename, sctEditor.Text);
                }
                catch (Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message);
                }
                m_dirty = false;
            }
        }

        private void sctEditor_TextInserted(object sender, ScintillaNET.TextModifiedEventArgs e)
        {
            m_dirty = true;
        }

        private void sctEditor_TextDeleted(object sender, ScintillaNET.TextModifiedEventArgs e)
        {
            m_dirty = true;
        }
    }
}
