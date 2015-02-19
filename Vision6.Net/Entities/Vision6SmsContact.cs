using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Vision6
{
    public class Vision6SmsContact : Vision6Object
    {        
        [JsonProperty("Mobile Phone")]
        public string Mobile { get; set; }

        [JsonProperty("Name")]
        public string Name { get; set; }
    }
}
