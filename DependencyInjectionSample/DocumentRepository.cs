using System;
namespace DependencyInjectionSample
{
    public class DocumentRepository: IDocumentRepository
    {
        public void Save()
        {
            Console.WriteLine("Document updated.");
        }
    }

    public interface IDocumentRepository
    {
        void Save();
    }
}
