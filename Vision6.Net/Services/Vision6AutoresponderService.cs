using System.Collections.Generic;

namespace Vision6
{
    public class Vision6AutoresponderService : Vision6Service
    {
        public virtual Vision6ResponseObject Count(int listId, int messageId)
        {
            var requestObject = new Vision6RequestObject
            {
                Method = Methods.CountAutoresponders,
            };

            var conditions = new List<object>
            {
                new Vision6SearchCondition { Parameter = "list_id", Comparison = Comparisons.Exactly, Value = listId }.ToList(),
                new Vision6SearchCondition { Parameter = "message_id", Comparison = Comparisons.Exactly, Value = messageId }.ToList()
            };

            requestObject.Params.Add(new List<object> {conditions});            

            return Requestor.Post(requestObject);
        }

        public virtual Vision6ResponseObject Add(Vision6Autoresponder autoResponder)
        {
            var requestObject = new Vision6RequestObject
            {
                Method = Methods.AddAutoresponder,
            };            

            requestObject.Params.Add(autoResponder);

            return Requestor.Post(requestObject);
        }

        public virtual Vision6ResponseObject AddIfNotExist(Vision6Autoresponder autoResponder)
        {
            var result = Count(autoResponder.ListId, autoResponder.MessageId);
            if (result.IsSuccess())
            {
                if ((int) result.Result == 0)
                {
                    return Add(autoResponder);
                }
            }
            return result;
        }
    }
}