using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using SharedModel;

namespace ImageRequest
{
    internal class UnsplashImageClient : IImageClient
    {

        private const string baseURI = "https://api.unsplash.com/";
        private HttpClient Client { get; }

        public UnsplashImageClient()
        {
            Client = new HttpClient();
            Client.BaseAddress = new Uri(baseURI);
            Client.DefaultRequestHeaders.Add("Authorization", ConfigurationManager.AppSettings[Constants.APIKEY]);
        }

        private IList<PowerPointImage> ExtractContent(string json)
        {
            Newtonsoft.Json.Linq.JObject imageResults = JObject.Parse(json);
            IList<JToken> results = imageResults["results"].Children().ToList();

            return results.Select(token => token.ToObject<PowerPointImage>()).ToList();
        }

        public async Task<IList<PowerPointImage>> MakeRequest(string query)
        {
            //TODO stop hardcoding and use Uri builder            
            var encodedQuery = System.Net.WebUtility.HtmlDecode(query);
            var request = new HttpRequestMessage(HttpMethod.Get, "search/photos/?query=" + encodedQuery);
            request.Headers.Add("Authorization", ConfigurationManager.AppSettings[Constants.APIKEY]);

            var response = await Client.SendAsync(request);

            if (response.Content != null)
            {
                var json = await response.Content.ReadAsStringAsync();
                //deserialize
                return ExtractContent(json);

            }
            throw new Exception();
  
        }
    }
}
