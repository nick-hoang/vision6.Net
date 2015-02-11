using Newtonsoft.Json;

namespace Vision6
{
    public class Vision6ResponseObject
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("result")]
        public dynamic Result { get; set; }

        [JsonProperty("error")]
        public int? Error { get; set; }   
     
        #region extensions
        public bool IsSuccess()
        {
            return Error == null;
        }

        public Vision6Error ErrorObject()
        {
            if (Error == null) return new Vision6Error();
            var errorObject = new Vision6Error
            {
                Code = Error.Value
            };
            switch (Error)
            {
                case 100:
                    errorObject.Text = "Internal Server Error";
                    errorObject.Description = "The System encountered an error.";
                    break;
                case 103:
                    errorObject.Text = "No Response from Server Call";
                    errorObject.Description = "The method did not return a value.";
                    break;
                case 104:
                    errorObject.Text = "Method Not Found";
                    errorObject.Description = "An undefined method was called. Check your version string or code for typographical errors.";
                    break;
                case 106:
                    errorObject.Text = "No XML Data Found";
                    errorObject.Description = "No XML was received by the server.";
                    break;
                case 107:
                    errorObject.Text = "Invalid Method Name";
                    errorObject.Description = "An undefined Method was called. Check your version string or code for typographical errors.";
                    break;
                case 108:
                    errorObject.Text = "Terms and Conditions not accepted";
                    errorObject.Description = "The Account you have logged into has not yet accepted the Terms and Conditions.";
                    break;
                case 303:
                    errorObject.Text = "Unable to Load List";
                    errorObject.Description = "list_id is not a valid List";
                    break;
                case 330:
                    errorObject.Text = "Contact Limit Reached";
                    errorObject.Description = "The Contact limit for the Account has been reached. One or more Contacts were not successfully added to the List.";
                    break;
                case 302:
                    errorObject.Text = "Undefined Error: No contacts could be added";
                    errorObject.Description = "No Contacts were added to the List. This is usually returned if all Contacts have invalid email addresses or mobile numbers. This error may also be returned if the Contacts array is not an array of one or more associative arrays of Contact details.";
                    break;
            }
            return errorObject;
        }

        #endregion
    }
}
