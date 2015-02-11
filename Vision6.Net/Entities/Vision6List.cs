using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Vision6
{
    public class Vision6List: Vision6Object
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("allow_send_to_duplicates")]
        public bool AllowSendToDuplicates { get; set; }

        [JsonProperty("contact_count")]
        public int ContactCount { get; set; }
    }
}
