namespace CodePreview
{
    partial class CodePreviewControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.sctEditor = new ScintillaNET.Scintilla();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.saveToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sctEditor)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.sctEditor);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(575, 396);
            this.panel1.TabIndex = 0;
            // 
            // sctEditor
            // 
            this.sctEditor.BackColor = System.Drawing.Color.DarkGray;
            this.sctEditor.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.sctEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sctEditor.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sctEditor.Location = new System.Drawing.Point(0, 24);
            this.sctEditor.Margins.FoldMarginColor = System.Drawing.Color.Black;
            this.sctEditor.Margins.FoldMarginHighlightColor = System.Drawing.Color.Black;
            this.sctEditor.Margins.Margin0.Width = 30;
            this.sctEditor.Margins.Margin1.Width = 15;
            this.sctEditor.Margins.Margin2.Width = 16;
            this.sctEditor.Name = "sctEditor";
            this.sctEditor.Size = new System.Drawing.Size(575, 372);
            this.sctEditor.Styles.BraceBad.FontName = "Verdana\0";
            this.sctEditor.Styles.BraceLight.FontName = "Verdana\0";
            this.sctEditor.Styles.CallTip.FontName = "Tahoma\0\0";
            this.sctEditor.Styles.ControlChar.FontName = "Verdana\0";
            this.sctEditor.Styles.Default.BackColor = System.Drawing.Color.DarkGray;
            this.sctEditor.Styles.Default.CharacterSet = ScintillaNET.CharacterSet.Ansi;
            this.sctEditor.Styles.Default.FontName = "Consolas";
            this.sctEditor.Styles.Default.Size = 8.25F;
            this.sctEditor.Styles.IndentGuide.FontName = "Verdana\0";
            this.sctEditor.Styles.LastPredefined.FontName = "Verdana\0";
            this.sctEditor.Styles.LineNumber.FontName = "Verdana\0";
            this.sctEditor.Styles.Max.FontName = "Verdana\0";
            this.sctEditor.TabIndex = 0;
            this.sctEditor.TextDeleted += new System.EventHandler<ScintillaNET.TextModifiedEventArgs>(this.sctEditor_TextDeleted);
            this.sctEditor.TextInserted += new System.EventHandler<ScintillaNET.TextModifiedEventArgs>(this.sctEditor_TextInserted);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(575, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // saveToolStripMenuItem1
            // 
            this.saveToolStripMenuItem1.Name = "saveToolStripMenuItem1";
            this.saveToolStripMenuItem1.Size = new System.Drawing.Size(43, 20);
            this.saveToolStripMenuItem1.Text = "&Save";
            this.saveToolStripMenuItem1.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // CodePreviewControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "CodePreviewControl";
            this.Size = new System.Drawing.Size(575, 396);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sctEditor)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private ScintillaNET.Scintilla sctEditor;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem1;

    }
}
