using System;
namespace DependencyInjectionSample
{
    public class DocumentRepository
    {
        public void Save()
        {
            Console.WriteLine("Document updated.");
        }
    }
}
