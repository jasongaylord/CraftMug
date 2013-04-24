using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CraftMug.Integrations.BeerMapping
{
    class LocState
    {
    }

    // Agagin, let's see if we can combine this with LocCity, LocImage, and others

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class bmp_locations
    {

        private bmp_locationsLocation locationField;

        /// <remarks/>
        public bmp_locationsLocation location
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
    public partial class bmp_locationsLocation
    {

        private string nameField;

        private string statusField;

        private decimal latField;

        private decimal lngField;

        private string mapField;

        private string altmapField;

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
        public decimal lat
        {
            get
            {
                return this.latField;
            }
            set
            {
                this.latField = value;
            }
        }

        /// <remarks/>
        public decimal lng
        {
            get
            {
                return this.lngField;
            }
            set
            {
                this.lngField = value;
            }
        }

        /// <remarks/>
        public string map
        {
            get
            {
                return this.mapField;
            }
            set
            {
                this.mapField = value;
            }
        }

        /// <remarks/>
        public string altmap
        {
            get
            {
                return this.altmapField;
            }
            set
            {
                this.altmapField = value;
            }
        }
    }


}
