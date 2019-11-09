using System;
namespace DependencyInjectionSample
{
    public class DocumentProcessor : IDocumentProcessor
    {
        IDocumentRepository _documentRepository;

        public DocumentProcessor(IDocumentRepository documentRepository)
        {
            _documentRepository = documentRepository;
        }

        public void UpdateDocument(int id, string path)
        {
            _documentRepository.Save();

            Console.WriteLine($"The document {id} was updated with the path {path}.");
        }
    }

    public interface IDocumentProcessor
    {
        void UpdateDocument(int id, string path);
    }
}
