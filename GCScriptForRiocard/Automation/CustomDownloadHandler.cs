using CefSharp;
using DocumentFormat.OpenXml.Wordprocessing;
using GCScriptForRiocard.Data;
using GCScriptForRiocard;

namespace GCScriptForRiocard.Automation
{
    class CustomDownloadHandler : IDownloadHandler
    {
        public event EventHandler<DownloadItem> OnBeforeDownloadFired;

        public event EventHandler<DownloadItem> OnDownloadUpdatedFired;

        private DownloadSettings _downloadSettings;

        public CustomDownloadHandler(DownloadSettings downloadSettings)
        {
            _downloadSettings = downloadSettings;
        }

        public bool CanDownload(IWebBrowser chromiumWebBrowser, IBrowser browser, string url, string requestMethod)
        {
            return true;
        }

        public void OnBeforeDownload(IWebBrowser chromiumWebBrowser, IBrowser browser, DownloadItem downloadItem, IBeforeDownloadCallback callback)
        {
            if (downloadItem.IsValid)
            {
                //Console.WriteLine("== File information ========================");
                //Console.WriteLine(" File URL: {0}", downloadItem.Url);
                //Console.WriteLine(" Suggested FileName: {0}", downloadItem.SuggestedFileName);
                //Console.WriteLine(" MimeType: {0}", downloadItem.MimeType);
                //Console.WriteLine(" Content Disposition: {0}", downloadItem.ContentDisposition);
                //Console.WriteLine(" Total Size: {0}", downloadItem.TotalBytes);
                //Console.WriteLine("============================================");
            }

            OnBeforeDownloadFired?.Invoke(this, downloadItem);

            if (!callback.IsDisposed)
            {
                using (callback)
                {
                    var pathx = Path.Combine(_downloadSettings.Directory, _downloadSettings.FileName);
                    callback.Continue(pathx, showDialog: _downloadSettings.ShowDialog);
                }
            }
        }

        public void OnDownloadUpdated(IWebBrowser chromiumWebBrowser, IBrowser browser, DownloadItem downloadItem, IDownloadItemCallback callback)
        {
            OnDownloadUpdatedFired?.Invoke(this, downloadItem);

            if (downloadItem.IsValid)
            {
                // Show progress of the download
                if (downloadItem.IsInProgress && downloadItem.PercentComplete != 0)
                {
                    //GCScriptForRiocard.Settings.percentLabel.Text = $"{downloadItem.PercentComplete}%";
                    Console.WriteLine($"Current Download Speed: {downloadItem.CurrentSpeed} bytes ({downloadItem.PercentComplete}%)");
                }

                if (downloadItem.IsComplete)
                {
                    MessageBox.Show($"Download concluído com sucesso!", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                }
            }
        }
    }
}
