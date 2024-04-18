using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compras.Libraries.Converters
{
    public class TextSharedListConverter : IValueConverter
    {
        public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            int? userCount = (int?)value;

            if (!userCount.HasValue)
                return null;
            return userCount > 1 ? "(lista compartilhada)" : string.Empty;

        }

        public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
