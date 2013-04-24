using CraftMug.Core.BeerMapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;

namespace CraftMug.Phone.Controls
{
    public class BeerLocationTemplateSelector : DataTemplateSelector
    {
        public DataTemplate WithBackgroundImage { get; set; }
        public DataTemplate WithoutBackgroundImage { get; set; }
        BeerListings beer;

        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            var location = item as LocCityLocation;
            
            if (location != null)
            {
                int imageCount = 0;
                if (int.TryParse(location.imagecount, out imageCount))
                {
                    if (imageCount > 0)
                    {
                        //beer = new BeerListings();
                        //beer.GetImagesSync(location.id.ToString());

                        //location.firstimage = beer.LocationImages.location[0].imageurl;

                        return WithBackgroundImage;
                    }
                }
                return WithoutBackgroundImage;
            }

            return base.SelectTemplate(item, container);
        }
    }
}