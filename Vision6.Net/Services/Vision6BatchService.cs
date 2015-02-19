using System.Collections.Generic;

namespace Vision6
{
    public class Vision6BatchService : Vision6Service
    {       
        public virtual Vision6ResponseObject Add(Vision6Batch batch)
        {
            var requestObject = new Vision6RequestObject
            {
                Method = Methods.AddBatch,
            };

            requestObject.Params.Add(batch.MessageId);            
            requestObject.Params.Add(batch.ContactList);            

            return Requestor.Post(requestObject);
        }        
    }
}