using System;
using System.IO;
using System.Net;
using System.Text;

namespace TestWebServices.Utils
{

    public class HttpProcessor
    {
        public static string CallWebService(string URL_ADDRESS, string xmlPayLoad, string contentType = "", int timeout = 15000)
        {
            // Get response and return it
            HttpWebRequest request = WebRequest.Create(new Uri(URL_ADDRESS)) as HttpWebRequest;

            byte[] byteData = Encoding.UTF8.GetBytes(xmlPayLoad);   // Create a byte array of the data we want to send

            request.Method = "POST";                                // Set type to POST
            request.Timeout = timeout; // Set timeout of 15 seconds
            request.ContentType = contentType ?? "application/xml";
            request.ContentLength = byteData.Length;                // Set the content length in the request headers

            // Create the data we want to send
            StringBuilder data = new StringBuilder();
            data.Append(xmlPayLoad);

            Stream dataStream = request.GetRequestStream();
            dataStream.Write(byteData, 0, byteData.Length);
            dataStream.Close();

            try
            {
                var webrequest = request.GetResponse();
                HttpWebResponse response = (HttpWebResponse)webrequest;
                dataStream = webrequest.GetResponseStream();
                StreamReader reader = new StreamReader(dataStream);
                string responseFromServer = reader.ReadToEnd();
                dataStream.Close();
                reader.Close();
                response.Close();

                if (response.StatusCode == HttpStatusCode.OK)
                    return responseFromServer;
                else
                    return null;

            }
            catch (WebException e)
            {
                throw new Exception(e.Message);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
