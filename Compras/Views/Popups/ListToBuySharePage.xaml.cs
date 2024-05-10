using Compras.Models;
using Compras.ViewModels;
using Mopups.Pages;

namespace Compras.Views.Popups;

public partial class ListToBuySharePage : PopupPage
{
	public ListToBuySharePage(ListaCompras list)
	{
		InitializeComponent();

		var vm = (ListToBuySharePageViewModel)BindingContext;
		vm.List = list;
	}
}