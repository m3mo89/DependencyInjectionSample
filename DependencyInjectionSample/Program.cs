using System;
using Autofac;

namespace DependencyInjectionSample
{
    class Program
    {
        public static IContainer Container;

        static void Main(string[] args)
        {
            Document document = new Document()
            {
                Id = 1,
                Url = "https://someweb.com/files/book.pdf"
            };

            ContainerBuilder containerBuilder = new ContainerBuilder();

            containerBuilder.RegisterType<DocumentManager>();
            containerBuilder.RegisterType<DownloadService>().As<IDownloadService>();
            containerBuilder.RegisterType<DocumentProcessor>().As<IDocumentProcessor>();
            containerBuilder.RegisterType<DocumentRepository>().As<IDocumentRepository>();

            Container = containerBuilder.Build();

            DocumentManager documentManager = Container.Resolve<DocumentManager>();

            documentManager.DownloadDocument(document);
        }
    }
}
