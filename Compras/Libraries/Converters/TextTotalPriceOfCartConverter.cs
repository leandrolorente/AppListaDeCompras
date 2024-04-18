using Compras.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compras.Libraries.Converters
{
    public class TextTotalPriceOfCartConverter : IValueConverter
    {
        public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            ListaCompras? listToBuy = value as ListaCompras;

            if (listToBuy is null)
                return "R$ 0,00";
            if(listToBuy.Products.Count == 0 )
                return "R$ 0,00";

            decimal totalPrice = 0;

            foreach(var product in listToBuy.Products)
            {
                // TODO - impacto na unidade de medida (analisar)
                if(product.HasCaught)
                    totalPrice += product.Price * product.Quantity;
            }

            return totalPrice.ToString("C");
        }

        public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
