using System;
using System.IO;
using System.Net;
using System.Text;

namespace Vision6
{
    internal static class Requestor
    {
        public static Vision6ResponseObject Post(Vision6RequestObject requestObject)
        {
            var wr = GetWebRequest();

            return ExecuteWebRequest(wr, requestObject);
        }        

        internal static WebRequest GetWebRequest()
        {            

            var request = (HttpWebRequest)WebRequest.Create(Urls.BaseUrl);
            request.Method = WebRequestMethods.Http.Post;
            request.Accept = "application/json";            
            request.ContentType = "application/json; charset=utf-8";            
            request.UserAgent = "Vision6.net (https://github.com/dstream/vision6.net)";

            return request;
        }

        private static Vision6ResponseObject ExecuteWebRequest(WebRequest webRequest, Vision6RequestObject requestObject)
        {
            try
            {
                using (var streamWriter = new StreamWriter(webRequest.GetRequestStream()))
                {
                    string json = Newtonsoft.Json.JsonConvert.SerializeObject(requestObject);

                    streamWriter.Write(json);
                    streamWriter.Flush();
                }
                using (var response = webRequest.GetResponse())
                {
                    var responseString = ReadStream(response.GetResponseStream());
                    return Newtonsoft.Json.JsonConvert.DeserializeObject<Vision6ResponseObject>(responseString);
                }
            }
            catch (WebException webException)
            {
                if (webException.Response != null)
                {
                    var statusCode = ((HttpWebResponse)webException.Response).StatusCode;

                    Vision6Error vision6Error;

                    if(webRequest.RequestUri.ToString().Contains("oauth"))
                        vision6Error = Mapper<Vision6Error>.MapFromJson(ReadStream(webException.Response.GetResponseStream()));
                    else
                        vision6Error = Mapper<Vision6Error>.MapFromJson(ReadStream(webException.Response.GetResponseStream()), "error");

                    throw new Vision6Exception(statusCode, vision6Error, vision6Error.Message);
                }

                throw;
            }
        }

        private static string ReadStream(Stream stream)
        {
            using (var reader = new StreamReader(stream, Encoding.UTF8))
            {
                return reader.ReadToEnd();
            }
        }
    }
}
