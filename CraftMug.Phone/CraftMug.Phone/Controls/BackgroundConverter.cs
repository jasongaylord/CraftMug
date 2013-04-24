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
    public class BackgroundConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string resourceName = value as string;
            if (!string.IsNullOrEmpty(resourceName))
            {
                return (SolidColorBrush)StyleController.FindResource(resourceName);
            }
            else
            {
                return (SolidColorBrush)StyleController.FindResource("StandardBrush");
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
    }

    public class LighterBackgroundConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string resourceName = value as string;
            if (!string.IsNullOrEmpty(resourceName))
            {
                return (SolidColorBrush)StyleController.FindResource(resourceName + " Lighter");
            }
            else
            {
                return (SolidColorBrush)StyleController.FindResource("StandardBrush Lighter");
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
    }
}