using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Vision6
{
    public class Vision6EmailContact : Vision6Object
    {
        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("mmwsection")]
        public string MmwSection { get; set; }

        [JsonProperty("mmw_unique_id")]
        public string MmwUniqueId { get; set; }

        [JsonProperty("mmwsalutation")]
        public string MmwSalutation { get; set; }

        [JsonProperty("subject_line")]
        public string SubjectLine { get; set; }        
    }
}
