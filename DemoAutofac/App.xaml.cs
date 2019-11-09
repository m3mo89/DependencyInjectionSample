using System;
using Autofac;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DemoAutofac
{
    public partial class App : Application
    {
        public static IContainer container;
        public static readonly ContainerBuilder builder = new ContainerBuilder();

        public App ()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }

        public static void RegisterType<T>() where T : class
        {
            builder.RegisterType<T>();
        }

        public static void RegisterType<TInterface, T>() where TInterface : class where T : class, TInterface
        {
            builder.RegisterType<T>().As<TInterface>();
        }

        public static void BuildContainer()
        {
            builder.RegisterType<MainViewModel>();
            container = builder.Build();
        }

        protected override void OnStart ()
        {
            // Handle when your app starts
        }

        protected override void OnSleep ()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume ()
        {
            // Handle when your app resumes
        }
    }
}
