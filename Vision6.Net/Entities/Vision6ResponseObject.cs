using Newtonsoft.Json;

namespace Vision6
{
    public class Vision6ResponseObject
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("result")]
        public dynamic Result { get; set; }

        [JsonProperty("error")]
        public Vision6Error Error { get; set; }   
     
        #region extensions
        public bool IsSuccess()
        {
            return Error == null;
        }        

        #endregion
    }
}
