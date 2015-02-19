using Newtonsoft.Json;

namespace Vision6
{
    public class Vision6Error
    {
        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }                
    }
}