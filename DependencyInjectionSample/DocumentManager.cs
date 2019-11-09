using System;
namespace DependencyInjectionSample
{
    public class DocumentManager
    {
        public void DownloadDocument(Document document)
        {
            DownloadService downloadService = new DownloadService();
            DocumentProcessor documentProcessor = new DocumentProcessor();

            var path = downloadService.Download(document.Url);
            documentProcessor.UpdateDocument(document.Id, path);
        }
    }
}
