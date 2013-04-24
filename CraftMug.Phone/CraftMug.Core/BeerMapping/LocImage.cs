using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace CraftMug.Core.BeerMapping
{
    /// <remarks/>
    [XmlRoot("bmp_locations")]
    [XmlType(AnonymousType = true)]
    public class LocImage
    {
        private LocImageLocation[] locationField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("location")]
        public LocImageLocation[] location
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
    public partial class LocImageLocation
    {
        private int imageidField;

        private string directurlField;

        private string imageurlField;

        private string widthField;

        private string heightField;

        private string thumburlField;

        private string captionField;

        private string creditField;

        private string crediturlField;

        private string imagedateField;

        private string scoreField;

        /// <remarks/>
        public int imageid
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
        public string width
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
        public string height
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
        public string score
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