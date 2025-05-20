using Autofac;
using RussianMultiplication.ViewModels;

namespace RussianMultiplication
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = App.Current.Container.Resolve<MainViewModel>();
        }
    }
}