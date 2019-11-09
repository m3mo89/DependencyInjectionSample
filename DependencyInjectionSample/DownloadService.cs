using System;
namespace DependencyInjectionSample
{
    public class DownloadService : IDownloadService
    {
        public string Download(string url)
        {
            // perform the download
            Console.WriteLine($"Document downloaded from {url}");

            return "localPath/book.pdf";
        }
    }

    public interface IDownloadService
    {
        string Download(string url);
    }
}
