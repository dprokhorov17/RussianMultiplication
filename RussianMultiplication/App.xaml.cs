using System.Windows;
using Autofac;
using RussianMultiplication.Services;
using RussianMultiplication.ViewModels;

namespace RussianMultiplication
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        public IContainer Container { get; private set; }
        
        public new static App Current => (App)Application.Current;

        protected override void OnStartup(StartupEventArgs e)
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<MainWindow>().AsSelf();
            builder.RegisterType<MainViewModel>().AsSelf();
            builder.RegisterType<Services.RussianMultiplication>().As<IRussianMultiplication>();
            Container = builder.Build();

            base.OnStartup(e);
        }
    }
}