using System;
namespace DependencyInjectionSample
{
    public class DocumentManager
    {
        IDownloadService _downloadService;
        IDocumentProcessor _documentProcessor;

        public DocumentManager(IDownloadService downloadService, IDocumentProcessor documentProcessor)
        {
            _downloadService = downloadService;
            _documentProcessor = documentProcessor;
        }

        public void DownloadDocument(Document document)
        {
            var path = _downloadService.Download(document.Url);
            _documentProcessor.UpdateDocument(document.Id, path);
        }
    }
}
