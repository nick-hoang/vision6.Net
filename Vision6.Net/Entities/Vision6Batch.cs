using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Vision6
{
    public class Vision6Batch : Vision6Object
    {        
        public int MessageId { get; set; }

        public List<Vision6BatchContact> ContactList { get; set; }

        /// <summary>
        /// still don't use
        /// </summary>
        public int SendTime { get; set; }

        /// <summary>
        /// still don't use
        /// </summary>
        public bool IsTest { get; set; }        
    }

    public class Vision6BatchContact : Vision6Object
    {
        [JsonProperty("list_id")]
        public int ListId { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("contact_list")]
        public List<int> ContactList { get; set; }

        [JsonProperty("time")]
        public string Time { get; set; }
    }
}
