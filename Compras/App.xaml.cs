using Compras.Views;

namespace Compras
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

           
            MainPage = VersionTracking.IsFirstLaunchEver ? new FirstPage() : new AppShell();
        }
    }
}
