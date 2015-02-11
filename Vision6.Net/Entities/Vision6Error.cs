using Newtonsoft.Json;

namespace Vision6
{
    public class Vision6Error
    {
        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("param")]
        public string Parameter { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
        
    }
}