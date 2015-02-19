using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Vision6
{
    public class Vision6Autoresponder : Vision6Object
    {
        [JsonProperty("list_id")]
        public int ListId { get; set; }

        [JsonProperty("message_id")]
        public int MessageId { get; set; }

        [JsonProperty("event_type")]
        public string EventType { get; set; }

        [JsonProperty("folder_id")]
        public int FolderId { get; set; }        
    }
}
