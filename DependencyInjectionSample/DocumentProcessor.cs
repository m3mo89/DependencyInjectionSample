using System;
namespace DependencyInjectionSample
{
    public class DocumentProcessor
    {
        public void UpdateDocument(int id, string path)
        {
            DocumentRepository documentRepository = new DocumentRepository();

            documentRepository.Save();

            Console.WriteLine($"The document {id} was updated with the path {path}.");
        }
    }
}
