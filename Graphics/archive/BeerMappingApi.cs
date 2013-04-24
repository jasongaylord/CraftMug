using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;

namespace CraftMug.Integrations
{
    public class BeerMappingApi
    {
        private const string Key = "49debbbf807ca852277c653bd36c0801";

        // TODO: Abstract this out to allow a return type to be injected
        public void sampleWebCall()
        {
            var request = WebRequest.Create(new Uri(/* your_google_url */)) as HttpWebRequest;
            request.Method = "POST";
            request.BeginGetRequestStream(ar =>
            {
                var requestStream = request.EndGetRequestStream(ar);
                using (var sw = new StreamWriter(requestStream))
                {
                    // Write the body of your request here
                }

                request.BeginGetResponse(a =>
                {
                    var response = request.EndGetResponse(a);
                    var responseStream = response.GetResponseStream();
                    using (var sr = new StreamReader(responseStream))
                    {
                        // Parse the response message here
                    }

                }, null);

            }, null);
        }
    }
}