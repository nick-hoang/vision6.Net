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

    /// <summary>
    /// http://developers.vision6.com.au/3.0/method/addbatch
    /// </summary>
    public class Vision6BatchContact : Vision6Object
    {
        /// <summary>
        /// string	The List ID of the Contacts who will be sent the Message.
        /// </summary>
        [JsonProperty("list_id")]
        public int ListId { get; set; }

        /// <summary>
        /// string	Either list to send to all contacts in the List, unsent to only send to Contacts who have not been sent the Message, or contacts to specify which Contacts to send to.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// array	An array containing the IDs of the Contacts to send to if the type has been set to contacts.
        /// </summary>
        [JsonProperty("contact_list")]
        public List<int> ContactList { get; set; }

        /// <summary>
        /// string	Either now or send. Dictates when the send processor populates the List of Contacts who will receive the Message, either immediately or at time of send.
        /// </summary>
        [JsonProperty("time")]
        public string Time { get; set; }
    }
}
