using System.Collections.Generic;

namespace Vision6
{
    public class Vision6ContactService : Vision6Service
    {
        /// <summary>
        /// Adds one or more Contacts to a List.
        /// </summary>
        /// <param name="listId">The ID of the List to add the Contacts to.</param>
        /// <param name="contacts">An array containing one or more associative arrays of Contact details. The Contact details are indexed using each of the Field names in the List</param>
        /// <param name="overwrite">A flag that determines how the method handles duplicates.</param>
        /// <param name="removeUnsubscribers">A flag that determines how the method handles unsubscribed Contacts. Valid values are: 0 (default), 1, 2</param>
        /// <returns></returns>
        public virtual Vision6ResponseObject Add(string listId, List<Vision6Contact> contacts, bool overwrite = false, int removeUnsubscribers = 0)
        {
            var requestObject = new Vision6RequestObject
            {
                Method = Methods.AddContacts,                
            };
            requestObject.Params.Add(listId);

            requestObject.Params.Add(contacts);

            requestObject.Params.Add(overwrite);

            requestObject.Params.Add(removeUnsubscribers);

            return Requestor.Post(requestObject);            
        }
    }
}