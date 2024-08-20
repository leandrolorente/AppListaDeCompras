using Compras.Views;

namespace Compras
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute("//ListToBuy/ListOfItens", typeof(ListOfItensPage));
        }
    }
}
