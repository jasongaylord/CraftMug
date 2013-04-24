using CraftMug.Core.BeerMapping;
using CraftMug.Core.Utilities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows;
using System.Windows.Data;
using System.Windows.Media;

namespace CraftMug.Phone.Controls
{
    public class FirstBeerLocationImageConverter : IValueConverter
    {
        BeerListings beer;

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var _event = new ManualResetEvent(false);
            string temp = "";
            int? id = value as int?;
            if (id.HasValue)
            {
                beer = new BeerListings();
                beer.GetImagesFakeSync(id.Value.ToString(), () =>
                {
                    temp = beer.LocationImages.location[0].imageurl;

                    //this.MyImage.Source = new BitmapImage(new Uri("/
                    //return temp;
                }, (error) =>
                {
                    temp = "ERROR";
                });

                _event.WaitOne(5000);
                                        //<StackPanel.Background><!--{Binding id, Converter={StaticResource FirstBeerLocationImageConverter}}-->
                                        //    <ImageBrush ImageSource="{Binding firstimage}" />
                return temp;
   
                // executes just after async call above

                //beer = new BeerListings();
                //beer.GetImagesSync(id.Value.ToString());
                //temp = beer.LocationImages.location[0].imageurl;
                //return temp;
            }
            else
            {
                return "";
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
    }
}

//[ValueConversion(typeof(object), typeof(string))]    
//public class StringFormatConverter : BaseConverter, IValueConverter    
//{        
//    public object Convert(object value, Type targetType, object parameter,
//                      System.Globalization.CultureInfo culture)        
//    {            
//        string format = parameter as string;
//        if (!string.IsNullOrEmpty(format))
//        {                
//             return string.Format(culture, format, value);
//        }
//        else           
//        {                
//            return value.ToString();
//    }
 
//    public object ConvertBack(object value, Type targetType, object parameter,
//                    System.Globalization.CultureInfo culture)
//    {
//        return null; 
//    }            
//}

