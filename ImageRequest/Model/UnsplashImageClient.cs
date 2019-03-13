using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using SharedModel;

namespace ImageRequest.Model
{


    public class UnsplashImageClient : IImageClient
    {

        private const string baseURI = "https://api.unsplash.com/";

        public UnsplashImageClient()
        {
            WebClient = new HttpClient();
            WebClient.BaseAddress = new Uri(baseURI);
            WebClient.DefaultRequestHeaders.Add("Authorization", ConfigurationManager.AppSettings[Constants.APIKEY]);
        }
        private HttpClient WebClient { get; }

        private IList<Image> ExtractContent(string json)
        {
            Newtonsoft.Json.Linq.JObject imageResults = JObject.Parse(json);
            IList<JToken> results = imageResults["results"].Children().ToList();

            return results.Select(token => token.ToObject<Image>()).ToList();
        }

        public async Task<string> MakeRequest(string query)
        {
            //todo stop hardcoding and use Uri builder
            UriBuilder uri = new UriBuilder();
            uri.Path = "search/photos";
            uri.Query = "query" + query;


            var request = new HttpRequestMessage(HttpMethod.Get, "search/photos/?query=" + query);
            request.Headers.Add("Authorization", ConfigurationManager.AppSettings[Constants.APIKEY]);

            var response = await WebClient.SendAsync(request);

            if (response.Content != null)
            {
                var json = await response.Content.ReadAsStringAsync();
                //deserialize
                var results = ExtractContent(json);
                //todo handle more
                return "Success";
            }
            return "Failure";
  
        }
    }
}
