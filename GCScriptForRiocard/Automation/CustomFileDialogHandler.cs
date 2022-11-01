using CefSharp;
using DocumentFormat.OpenXml.Wordprocessing;
using GCScriptForRiocard.Data;

namespace GCScriptForRiocard.Automation
{
    public class CustomFileDialogHandler : IDialogHandler
    {
        private List<string> _filePath;

        public CustomFileDialogHandler(List<string> filePath)
        {
            _filePath = filePath;
        }

        public bool OnFileDialog(IWebBrowser chromiumWebBrowser, IBrowser browser, CefFileDialogMode mode, string title, string defaultFilePath, List<string> acceptFilters, IFileDialogCallback callback)
        {
            
            callback.Continue(_filePath);
            return true;
        }
    }
}
