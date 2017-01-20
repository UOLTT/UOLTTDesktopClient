using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;
using DataDelivery.Classes;

namespace DataDelivery
{
    internal class Common
    {
        /// <summary>
        /// Makes the data request to the API for a list of items
        /// </summary>
        /// <param name="requestEnum">Enum data type that tells what kind of request is needed</param>
        /// <returns>JSON string for a list of items</returns>
        internal static string LoadData(GetCalls requestEnum)
        {
            string requestString = GetDataRequests.RetrieveGetStringRequest(requestEnum);
            return LoadGetRequest(requestString);
        }

        /// <summary>
        /// Makes the data request to the API for a single item
        /// </summary>
        /// <param name="requestEnum">Enum data type that tells what kind of request is needed</param>
        /// <param name="id">Id for the specific item that is required</param>
        /// <returns>JSON string for the single item</returns>
        internal static string LoadData(GetCalls requestEnum, int id)
        {
            string requestString = GetDataRequests.RetrieveGetStringRequest(requestEnum, id);
            return LoadGetRequest(requestString);
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
