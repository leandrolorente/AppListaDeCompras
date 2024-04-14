using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compras.Models
{
    public class ListaCompras
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public List<Product> Products { get; set; } = new List<Product>();
        public List<User> Users { get; set; } = new List<User>();

        public DateTimeOffset CreateDate { get; set; }
        public int Qtde { get; set; }
    }
}
