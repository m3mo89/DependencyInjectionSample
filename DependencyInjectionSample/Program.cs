using System;

namespace DependencyInjectionSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Document document = new Document()
            {
                Id = 1,
                Url = "https://someweb.com/files/book.pdf"
            };

            DocumentManager documentManager = new DocumentManager();
            documentManager.DownloadDocument(document);
        }
    }
}
