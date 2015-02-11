using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Vision6
{
    public class Vision6Contact : Vision6Object
    {
        [JsonProperty("Email")]
        public string Email { get; set; }

        [JsonProperty("Mobile Phone")]
        public string Mobile { get; set; }
    }
}
