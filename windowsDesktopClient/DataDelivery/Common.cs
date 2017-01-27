using Newtonsoft.Json;
using System;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace DataDelivery
{
    internal class Common
    {

        #region Priave Methods

        /// <summary>
        /// Takes the JSON string and deserializes it into the passed in object type
        /// </summary>
        /// <typeparam name="ReturnType">The object for the JSON to be deserialized into</typeparam>
        /// <param name="jsonData">The Json String retrieved from the <see cref="LoadGetRequest(string)"/> method</param>
        /// <returns></returns>
        private static ReturnType FromJson<ReturnType>(string jsonData)
        {
            ReturnType deserilisedObject = JsonConvert.DeserializeObject<ReturnType>(jsonData);
            return deserilisedObject;
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

                const string messageBoxText = "There Was an Error";
                const string caption = "UOLTT Desktop Application";
                const MessageBoxButtons button = MessageBoxButtons.OK;

                MessageBox.Show(messageBoxText, caption, button);

                throw;
            }
        }
        #endregion

        #region Internally Exposed Methods

        /// <summary>
        /// Makes the data request to the API for a single item
        /// </summary>
        /// <param name="requestEnum">Enum data type that tells what kind of request is needed</param>
        /// <param name="id">Id for the specific item that is required</param>
        /// <returns>JSON string for the single item</returns>
        internal static T LoadData<T>(GetCalls requestEnum, int? id = null)
        {
            string requestString = id.HasValue ? GetDataRequests.RetrieveGetStringRequest(requestEnum, (int)id) : GetDataRequests.RetrieveGetStringRequest(requestEnum);

            string jsonData =  LoadGetRequest(requestString);

            return FromJson<T>(jsonData);
        }

        #endregion

    }
}
