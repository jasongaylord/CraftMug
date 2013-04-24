using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Runtime.Serialization.Json;

namespace CraftMug.Core.Nokia
{
    public class Map
    {
        string placesUri = "http://demo.places.nlp.nokia.com/places/v1/discover/search?at={0}%2C{1}&q=&app_id={2}&app_code={3}&accept=application%2Fjson";
        private Place placeStruct;
        public event EventHandler PlaceDetailsObtained;

        public Location PlaceDetails 
        {
            get
            {
                return this.placeStruct.search.context.location;
            }
        }

        private Place PlaceStruct
        {
            get
            {
                return this.placeStruct;
            }
            set
            {
                if (value != this.placeStruct)
                {
                    this.placeStruct = value;
                    if (this.PlaceDetailsObtained != null)
                        this.PlaceDetailsObtained(this, new EventArgs());
                }
            }
        }

        // Possibly update the calls here
        // http://stackoverflow.com/questions/10666542/httpwebrequest-on-windows-phone-7
        // http://www.silverlightshow.net/items/Windows-Phone-7-Data-Access-Strategies-HttpWebRequest.aspx
        public void GetPlaceDetails(string latitude, string longitude)
        {
            var placeDetails = new Place();
            var requestUri = string.Format(placesUri, latitude, longitude, Pids.NokiaAppId, Pids.NokiaAppToken);
            HttpWebRequest request = HttpWebRequest.Create(requestUri) as HttpWebRequest;
            request.Accept = "application/json"; //atom+xml";
            request.BeginGetResponse(GetDetailedLocationDataCallback, request);
        }

        private void GetDetailedLocationDataCallback(IAsyncResult result)
        {
            var request = result.AsyncState as HttpWebRequest;
            var response = request.EndGetResponse(result);

            if (response != null)
            {
                var jsonSerializer = new DataContractJsonSerializer(typeof(Place));

                using (var stream = response.GetResponseStream())
                {
                    PlaceStruct = jsonSerializer.ReadObject(stream) as Place;
                }
            }
        }
    }

    public class Place
    {
        public Results results { get; set; }
        public Search search { get; set; }
    }

    public class Results
    {
        public object[] items { get; set; }
    }

    public class Search
    {
        public Context context { get; set; }
    }

    public class Context
    {
        public Location location { get; set; }
        public string type { get; set; }
        public string href { get; set; }
    }

    public class Location
    {
        public float[] position { get; set; }
        public Address address { get; set; }
    }

    public class Address
    {
        public string house { get; set; }
        public string street { get; set; }
        public string postalCode { get; set; }
        public string city { get; set; }
        public string stateCode { get; set; }
        public string county { get; set; }
        public string countryCode { get; set; }
        public string country { get; set; }
        public string text { get; set; }
    }
}