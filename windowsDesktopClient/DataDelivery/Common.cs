using Newtonsoft.Json;
using System;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;
using windowsDesktopClient.Classes;

namespace DataDelivery
{
    internal class Common
    {
        internal static string LoadData(GetCalls requestEnum)
        {
            var vara = GetDataRequests.RetrieveGetStringRequest(requestEnum);
            return LoadGetRequest(vara);
        }

        internal static string LoadData(GetCalls requestEnum, int id)
        {
            var vara = GetDataRequests.RetrieveGetStringRequest(requestEnum, id);
            return LoadGetRequest(vara);
        }


        /// <summary>
        /// Makes a JSON GET web request
        /// </summary>
        /// <param name="url">The URL to perform the web request on</param>
        /// <returns>String containing the JSON response from the URL</returns>
        private static string LoadGetRequest(string url)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            try
            {
                WebResponse response = request.GetResponse();
                using (Stream responseStream = response.GetResponseStream())
                {
                    StreamReader reader = new StreamReader(responseStream, Encoding.UTF8);
                    return reader.ReadToEnd();
                }
            }
            catch (WebException ex)
            {
                WebResponse errorResponse = ex.Response;
                using (Stream responseStream = errorResponse.GetResponseStream())
                {
                    StreamReader reader = new StreamReader(responseStream, Encoding.GetEncoding("utf-8"));
                    String errorText = reader.ReadToEnd();
                    // log errorText
                }

                string messageBoxText = "There Was an Error";
                string caption = "UOLTT Desktop Application";
                MessageBoxButtons button = MessageBoxButtons.OK;

                MessageBox.Show(messageBoxText, caption, button);

                throw;
            }
        }

    }
}
