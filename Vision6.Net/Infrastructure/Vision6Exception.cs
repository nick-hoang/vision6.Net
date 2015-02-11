using System;
using System.Net;

namespace Vision6
{
    [Serializable]
    public class Vision6Exception : ApplicationException
    {
        public HttpStatusCode HttpStatusCode { get; set; }
        public Vision6Error Vision6Error { get; set; }

        public Vision6Exception() 
        { 
        }

        public Vision6Exception(HttpStatusCode httpStatusCode, Vision6Error error, string message)
            : base(message)
        {
            HttpStatusCode = httpStatusCode;
            Vision6Error = error;
        }
    }
}