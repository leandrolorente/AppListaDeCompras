using CommunityToolkit.Mvvm.ComponentModel;
using Compras.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compras.ViewModels
{
    [QueryProperty(nameof(ListToBuy), "ListToBuy")]

    public partial class ListOfItensPageViewModel : ObservableObject
    {
        /*[ObservableProperty]
        private ListaCompras listToBuy;*/

        private ListaCompras? _listToBuy;
        public ListaCompras? ListToBuy
        {
            get => _listToBuy;
            set => SetProperty(ref _listToBuy, value);
        }
         
    }
}
