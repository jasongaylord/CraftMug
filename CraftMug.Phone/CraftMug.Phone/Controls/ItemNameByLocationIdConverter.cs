using CraftMug.Core.BeerMapping;
using CraftMug.Core.Utilities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Data;
using System.Windows.Media;

namespace CraftMug.Phone.Controls
{
    public class ItemNameByLocationIdConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            int? id = value as int?;
            if (id.HasValue)
            {
                return "sp-location-" + id.Value.ToString();
            }
            else
            {
                return "test-item";
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
    }
}