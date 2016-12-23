using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace windowsDesktopClient
{
    public partial class Home : Form
    {

        /// <summary>
        /// Hides all panels and then shows panel passed in
        /// </summary>
        /// <param name="panel"> The Panel to be shown in the form </param>
        private void PanelChange(Panel panel)
        {

            foreach (Panel p in this.Controls.OfType<Panel>())
            {
                p.Hide();
            }
            panel.Show();
        }
        
        /// <summary>
        /// Makes a JSON web request
        /// </summary>
        /// <param name="url">The URL to perform the web request on</param>
        /// <returns>String containing the JSON response from the URL</returns>
        static string GET(string url)
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
                throw;
            }
        }
        public Home()
        {
            InitializeComponent();
        }

        private void ShipButton_Click(object sender, EventArgs e)
        {
            PanelChange(shipPanel);
        }

        private void OrgButton_Click(object sender, EventArgs e)
        {
            PanelChange(orgPanel);
        }

        private void PriceButton_Click(object sender, EventArgs e)
        {
            PanelChange(pricePanel);
        }
    }
}
