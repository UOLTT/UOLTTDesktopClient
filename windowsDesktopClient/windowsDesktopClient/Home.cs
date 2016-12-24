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
            List<ShipExtended> listOfShips = JsonConvert.DeserializeObject<List<ShipExtended>>(GET(ApiCalls.ShipList));
            foreach (var item in listOfShips)
            {
                ShipDropDown.Items.Add(item);
            }
            ShipDropDown.DisplayMember = "ShipName";
        }

        private void OrgButton_Click(object sender, EventArgs e)
        {
        }

        private void PriceButton_Click(object sender, EventArgs e)
        {
        }

        private void ShipDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShipExtended selected = (ShipExtended)ShipDropDown.SelectedItem;
            textBox1.Text = Convert.ToString(selected.Id);
            textBox2.Text = selected.ShipName;
            textBox3.Text = Convert.ToString(selected.Height + "m");
            textBox4.Text = Convert.ToString(selected.Length + "m");
            textBox5.Text = Convert.ToString(selected.Beam + "m");
        }
    }
}
