using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Compras.Models;
using Mopups.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compras.ViewModels
{
    public partial class ListToBuySharePageViewModel : ObservableObject
    {
        [ObservableProperty]
        private ListaCompras _list = new ListaCompras() { Users = new List<User>()};

        [RelayCommand]
        private void Close()
        {
            MopupService.Instance.PopAsync();
        }
    }
}
