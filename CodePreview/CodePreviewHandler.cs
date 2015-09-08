using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using SharpShell.Attributes;
using SharpShell.SharpPreviewHandler;

namespace CodePreview
{
    [COMServerAssociation(AssociationType.ClassOfExtension, ".cs", ".c", ".cpp", ".h", ".py", ".bat", ".cmd", ".xml")]
    [DisplayName("Code File Preview Handler")]
    [ComVisible(true)]
    [Guid("841B5971-C2F2-42F1-BDE5-0EA47CDCD881")]
    public class CodePreviewHandler : SharpPreviewHandler
    {
        protected override PreviewHandlerControl DoPreview()
        {
            //  Create the handler control.
            var handler = new CodePreviewControl();

            //  Do we have a file path? If so, we can do a preview.
            if (!string.IsNullOrEmpty(SelectedFilePath))
                handler.DoPreview(SelectedFilePath);
            //  Return the handler control.
            return handler;
        }

        private bool IsHandledType(string filepath)
        {
            return false;
        }
    }
}
