using CommunityToolkit.Mvvm.ComponentModel;
using Compras.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compras.ViewModels
{
    public partial class ListaComprasViewModel : ObservableObject
    {
        [ObservableProperty]
        private ObservableCollection<ListaCompras> _listaCompras;
        public ListaComprasViewModel() 
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
                        new Product{},
                        new Product{},
                        new Product{},
                        new Product{}
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
                        new Product{},
                        new Product{},
                        new Product{},
                        new Product{}
                    }
                },
            };

        }

    }
}
