using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;

namespace FixedLengthSample
{
    public class HttpHelper
    {
        private static CookieContainer cookie = new CookieContainer();

        private static int _webTimeout = 100000;
        public static int WebTimeout
        {
            get
            {
                return _webTimeout;
            }
            set
            {
                _webTimeout = value;
            }
        }

        public static string Get(string url, bool enableCookie, Encoding encoding)
        {
            string content = string.Empty;
            HttpWebRequest request = null;
            try
            {
                request = (HttpWebRequest)WebRequest.Create(url);
                request.Credentials = CredentialCache.DefaultCredentials;
                request.Timeout = WebTimeout;

                if (enableCookie)
                {
                    request.CookieContainer = cookie;
                }

                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    using (StreamReader reader = new StreamReader(response.GetResponseStream(), encoding))
                    {
                        content = reader.ReadToEnd();
                    }
                }

                return content;
            }
            catch (System.Net.WebException ex)
            {
                if (ex.Message.Contains("404"))
                {
                    return content;
                }
                else
                {
                    throw;
                }
            }
            catch
            {
                throw;
            }
            finally
            {
                request = null;
            }
        }

     
        public static string Post(string url, string requestData, string contentType)
        {
            string responseData;

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "POST";
            request.ContentType = contentType;//"application/x-www-form-urlencoded"; //"text/xml;charset=UTF-8";
            //request.ContentType = "application/json;charset=UTF-8";
            request.ServicePoint.Expect100Continue = false;
            request.Timeout = 300000;

            byte[] byteParamets = Encoding.UTF8.GetBytes(requestData);
            request.ContentLength = byteParamets.Length;
            using (Stream writer = request.GetRequestStream())
            {
                writer.Write(byteParamets, 0, byteParamets.Length);
            }

            var response = (HttpWebResponse)request.GetResponse();
            using (var reader = new StreamReader(response.GetResponseStream(), Encoding.UTF8))
            {
                responseData = reader.ReadToEnd();
            }

            return responseData;
        }
        public static string Post(string url, string requestData)
        {
            return Post(url, requestData, "application/x-www-form-urlencoded");
        }
    }
}
