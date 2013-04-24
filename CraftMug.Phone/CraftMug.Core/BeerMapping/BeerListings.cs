using CraftMug.Core.Utilities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization;
using System.Text;
using System.Threading;
using System.Xml.Serialization;

namespace CraftMug.Core.BeerMapping
{
    public class BeerListings
    {
        string locCityUri = "http://beermapping.com/webservice/loccity/{0}/{1},{2}";
        string locImageUri = "http://beermapping.com/webservice/locimage/{0}/{1}";

        private LocCity locCity;
        private LocImage locImage;
        public event EventHandler LocationsRetrieved;
        public event EventHandler ImagesRetrieved;
        
        WebClient webClient;
        public ManualResetEvent _event;

        public LocCity LocationsByCity
        {
            get
            {
                return this.locCity;
            }
            set
            {
                if (value != this.locCity)
                {
                    this.locCity = value;
                    if (this.LocationsRetrieved != null)
                        this.LocationsRetrieved(this, new EventArgs());
                }
            }
        }

        public LocImage LocationImages
        {
            get
            {
                return this.locImage;
            }
            set
            {
                if (value != this.locImage)
                {
                    this.locImage = value;
                    if (this.ImagesRetrieved != null)
                        this.ImagesRetrieved(this, new EventArgs());
                }
            }
        }

        public void GetBeerPlaces(string city, string state)
        {
            var requestUri = string.Format(locCityUri, Pids.BeerMappingToken, city, state);
            HttpWebRequest request = HttpWebRequest.Create(requestUri) as HttpWebRequest;
            request.Accept = "application/xml";
            request.BeginGetResponse(GetPlaceDetailsCallback, request);
        }

        private void GetPlaceDetailsCallback(IAsyncResult result)
        {
            var request = result.AsyncState as HttpWebRequest;
            var response = request.EndGetResponse(result);

            if (response != null)
            {
                var serializer = new XmlSerializer(typeof(LocCity));
                try
                {
                    LocationsByCity = (LocCity)serializer.Deserialize(response.GetResponseStream());
                }
                catch (Exception ex)
                {
                }
            }
        }

        public void GetImages(string locationId)
        {
            var requestUri = string.Format(locImageUri, Pids.BeerMappingToken, locationId);
            HttpWebRequest request = HttpWebRequest.Create(requestUri) as HttpWebRequest;
            request.Accept = "application/xml";
            request.BeginGetResponse(GetImageCallback, request);
        }

        public void GetImagesFakeSync(string locationId, Action callback, Action<Exception> error)
        {
            var requestUri = string.Format(locImageUri, Pids.BeerMappingToken, locationId);
            webClient = new WebClient();

            webClient.DownloadStringCompleted += (p, q) =>
            {
                if (q.Error == null)
                {
                    var serializer = new XmlSerializer(typeof(LocImage));
                    LocationImages = (LocImage)serializer.Deserialize(new StringReader(q.Result));

                    callback();
                }
                else
                {
                    error(q.Error);
                }
            };
            webClient.DownloadStringAsync(new Uri(requestUri));
        }

        //private void ReadImagesCompleted(object sender, OpenReadCompletedEventArgs e)
        //{
        //    var serializer = new XmlSerializer(typeof(LocImage));
        //    LocationImages = (LocImage)serializer.Deserialize(e.Result);

        //    // set event to unblock caller
        //    _event.Set();
        //}

        private void GetImageCallback(IAsyncResult result)
        {
            var request = result.AsyncState as HttpWebRequest;
            var response = request.EndGetResponse(result);

            if (response != null)
            {
                var serializer = new XmlSerializer(typeof(LocImage));
                try
                {
                    LocationImages = (LocImage)serializer.Deserialize(response.GetResponseStream());
                }
                catch (Exception ex)
                {
                }
            }
        }
    }
}