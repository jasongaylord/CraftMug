using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Xml.Serialization;

namespace CraftMug.Core.BeerMapping
{
    /// <remarks/>
    //[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    //[System.Xml.Serialization.XmlRootAttribute("bmp_locations")] //, Namespace = "", IsNullable = false)]
    [XmlRoot("bmp_locations")]
    [XmlType(AnonymousType = true)]
    public class LocCity
    {
        private LocCityLocation[] locationField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("location")]
        public LocCityLocation[] location
        {
            get
            {
                return this.locationField;
            }
            set
            {
                this.locationField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class LocCityLocation
    {

        private int idField;

        private string nameField;

        private string statusField;

        private string reviewlinkField;

        private string proxylinkField;

        private string blogmapField;

        private string streetField;

        private string cityField;

        private string stateField;

        private string zipField;

        private string countryField;

        private string phoneField;

        private string overallField;

        private string imagecountField;

        private string firstImageField;

        /// <remarks/>
        public int id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        public string status
        {
            get
            {
                return this.statusField;
            }
            set
            {
                this.statusField = value;
            }
        }

        /// <remarks/>
        public string reviewlink
        {
            get
            {
                return this.reviewlinkField;
            }
            set
            {
                this.reviewlinkField = value;
            }
        }

        /// <remarks/>
        public string proxylink
        {
            get
            {
                return this.proxylinkField;
            }
            set
            {
                this.proxylinkField = value;
            }
        }

        /// <remarks/>
        public string blogmap
        {
            get
            {
                return this.blogmapField;
            }
            set
            {
                this.blogmapField = value;
            }
        }

        /// <remarks/>
        public string street
        {
            get
            {
                return this.streetField;
            }
            set
            {
                this.streetField = value;
            }
        }

        /// <remarks/>
        public string city
        {
            get
            {
                return this.cityField;
            }
            set
            {
                this.cityField = value;
            }
        }

        /// <remarks/>
        public string state
        {
            get
            {
                return this.stateField;
            }
            set
            {
                this.stateField = value;
            }
        }

        /// <remarks/>
        public string zip
        {
            get
            {
                return this.zipField;
            }
            set
            {
                this.zipField = value;
            }
        }

        /// <remarks/>
        public string country
        {
            get
            {
                return this.countryField;
            }
            set
            {
                this.countryField = value;
            }
        }

        /// <remarks/>
        public string phone
        {
            get
            {
                return this.phoneField;
            }
            set
            {
                this.phoneField = value;
            }
        }

        /// <remarks/>
        public string overall
        {
            get
            {
                return this.overallField;
            }
            set
            {
                this.overallField = value;
            }
        }

        /// <remarks/>
        public string imagecount
        {
            get
            {
                return this.imagecountField;
            }
            set
            {
                int imageCount = 0;
                int.TryParse(value, out imageCount);                   
                this.imagecountField = imageCount.ToString();

                // Check to see if the image count is a valid int and if it's greater than 0, let's get the URL of the first image
                var _event = new ManualResetEvent(false);

                if (imageCount > 0)
                {
                    var beer = new BeerListings();
                    beer.GetImagesFakeSync(this.idField.ToString(), () =>
                    {
                        firstimage = beer.LocationImages.location[0].imageurl;
                    }, (error) =>
                    {
                    });

                    _event.WaitOne(3000);
                }
            }
        }

        /// <remarks/>
        public string firstimage
        {
            get
            {
                return this.firstImageField;
            }
            set
            {
                this.firstImageField = value;
            }
        }
    }
}