using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Compras.Models;
using Compras.Views.Popups;
using Mopups.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compras.ViewModels
{
    public partial class ListToBuyViewModel : ObservableObject
    {
        [ObservableProperty]
        private ObservableCollection<ListaCompras> _listaCompras;
        public ListToBuyViewModel() 
        {
            _listaCompras = new ObservableCollection<ListaCompras>()
            {
                new ListaCompras()
                {
                    Name = "lista 1",
                    Users = new List<User>
                    {
                        new User{Name = "Leandro Lorente", Email = "leandrolorente250@gmail.com"},
                        new User{Name = "Thaona", Email = "marquesthaoana@gmail.com"}
                    },
                    Products = new List<Product>
                    {
                        new Product{Quantity = 2, Name = "Arroz 5Kg", Price = 28.99m, HasCaught = true},
                        new Product{Quantity = 1, Name = "Feijão 1Kg", Price = 7.99m, HasCaught = true},
                        new Product{Quantity = 3, Name = "Leite Condensado", Price = 5.99m},
                        new Product{Quantity = 2, Name = "Molho de tomate", Price = 2.99m}
                    }
                },
                new ListaCompras()
                {
                    Name = "lista 2",
                    Users = new List<User>
                    {
                        new User{Name = "Leandro Lorente", Email = "leandrolorente250@gmail.com"},             
                    },
                    Products = new List<Product>
                    {
                        new Product{Quantity = 2, Name = "Arroz 5Kg", Price = 36.99m, HasCaught = true},
                        new Product{Quantity = 2, Name = "Feijão 1Kg", Price = 8.99m, HasCaught = true},
                        new Product{Quantity = 3, Name = "Leite Condensado", Price = 8.99m, HasCaught = true},

                    }
                },
            };

        }


        // TO DO - colocar parametro "listtobuy"
        [RelayCommand]
        private void OpenPopupSharePage()
        {
            MopupService.Instance.PushAsync(new ListToBuySharePage());
        }

    }
}
