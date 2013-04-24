using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CraftMug.Integrations.BeerMapping
{
    class LocCity
    {
    }

    // TODO: Check for duplication and let's see if we can abstract this further and come up with a combined XML class list

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class bmp_locations
    {

        private bmp_locationsLocation[] locationField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("location")]
        public bmp_locationsLocation[] location
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

        private ushort idField;

        private string nameField;

        private string statusField;

        private string reviewlinkField;

        private string proxylinkField;

        private string blogmapField;

        private string streetField;

        private string cityField;

        private string stateField;

        private uint zipField;

        private string countryField;

        private string phoneField;

        private decimal overallField;

        private byte imagecountField;

        /// <remarks/>
        public ushort id
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
        public uint zip
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
        public decimal overall
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
        public byte imagecount
        {
            get
            {
                return this.imagecountField;
            }
            set
            {
                this.imagecountField = value;
            }
        }
    }
}