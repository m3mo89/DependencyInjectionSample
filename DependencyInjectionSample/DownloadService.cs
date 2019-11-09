using System;
namespace DependencyInjectionSample
{
    public class DownloadService
    {
        public string Download(string url)
        {
            // perform the download
            Console.WriteLine($"Document downloaded from {url}");

            return "localPath/book.pdf";
        }
    }
}
