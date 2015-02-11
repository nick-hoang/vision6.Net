using System.Collections.Generic;
using Newtonsoft.Json;

namespace Vision6
{
    public class Vision6RequestObject
    {        
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("method")]
        public string Method { get; set; }

        [JsonProperty("params")]
        public List<object> Params { get; set; }

        public Vision6RequestObject()
        {
            //add API key as first element
            Params = new List<object> {Vision6Configuration.GetApiKey()};
        }
        public Vision6RequestObject(string apiKey)
        {
            //add API key as first element
            Params = new List<object> { apiKey };
        }
        
    }
}