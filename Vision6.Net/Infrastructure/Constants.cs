using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vision6
{
    public class Methods
    {
        public const string AddContacts = "addContacts";
        public const string CountAutoresponders = "countAutoresponders";
        public const string AddAutoresponder = "addAutoresponder";
        public const string AddBatch = "addBatch";
        public const string SearchLists = "searchLists";
    }

    /// <summary>
    /// Search comparitions
    /// </summary>
    public class Comparisons
    {
        public const string Exactly = "exactly";
    }

    public class AutoResponderEventType
    {
        /// <summary>
        /// A new Contact subscribes to a List.
        /// </summary>
        public const string Subscribe = "subscribe";
        /// <summary>
        /// An existing Contact unsubscribes from a List.
        /// </summary>
        public const string Unsubscribe = "unsubscribe";
        /// <summary>
        /// A Contact updates her profile.
        /// </summary>
        public const string UpdateProfile = "update_profile";
        /// <summary>
        /// A new Contact confirms his subscription (Email address).
        /// </summary>
        public const string Confirm = "confirm";
    }
}
