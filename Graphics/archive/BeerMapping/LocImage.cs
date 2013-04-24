using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CraftMug.Integrations.BeerMapping
{
    class LocImage
    {
    }

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

        private ushort imageidField;

        private string directurlField;

        private string imageurlField;

        private ushort widthField;

        private ushort heightField;

        private string thumburlField;

        private string captionField;

        private string creditField;

        private string crediturlField;

        private string imagedateField;

        private byte scoreField;

        /// <remarks/>
        public ushort imageid
        {
            get
            {
                return this.imageidField;
            }
            set
            {
                this.imageidField = value;
            }
        }

        /// <remarks/>
        public string directurl
        {
            get
            {
                return this.directurlField;
            }
            set
            {
                this.directurlField = value;
            }
        }

        /// <remarks/>
        public string imageurl
        {
            get
            {
                return this.imageurlField;
            }
            set
            {
                this.imageurlField = value;
            }
        }

        /// <remarks/>
        public ushort width
        {
            get
            {
                return this.widthField;
            }
            set
            {
                this.widthField = value;
            }
        }

        /// <remarks/>
        public ushort height
        {
            get
            {
                return this.heightField;
            }
            set
            {
                this.heightField = value;
            }
        }

        /// <remarks/>
        public string thumburl
        {
            get
            {
                return this.thumburlField;
            }
            set
            {
                this.thumburlField = value;
            }
        }

        /// <remarks/>
        public string caption
        {
            get
            {
                return this.captionField;
            }
            set
            {
                this.captionField = value;
            }
        }

        /// <remarks/>
        public string credit
        {
            get
            {
                return this.creditField;
            }
            set
            {
                this.creditField = value;
            }
        }

        /// <remarks/>
        public string crediturl
        {
            get
            {
                return this.crediturlField;
            }
            set
            {
                this.crediturlField = value;
            }
        }

        /// <remarks/>
        public string imagedate
        {
            get
            {
                return this.imagedateField;
            }
            set
            {
                this.imagedateField = value;
            }
        }

        /// <remarks/>
        public byte score
        {
            get
            {
                return this.scoreField;
            }
            set
            {
                this.scoreField = value;
            }
        }
    }
}
