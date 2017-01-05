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
using windowsDesktopClient.Classes;

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
            List<Ship> listOfShips = JsonConvert.DeserializeObject<List<Ship>>(GET(ApiCalls.ShipList));
            foreach (var item in listOfShips)
            {
                ShipDropDown.Items.Add(item);
            }
            ShipDropDown.DisplayMember = "ShipName";

            List<Organisation> listOfOrgs = JsonConvert.DeserializeObject<List<Organisation>>(GET(ApiCalls.OrgList));
            foreach (var item in listOfOrgs)
            {
                OrgDropDown.Items.Add(item);
            }
            OrgDropDown.DisplayMember = "Name";
            Ship testShip = JsonConvert.DeserializeObject<Ship>(GET(ApiCalls.ShipIndividual + "69"));
        }
        
        private void ShipButton_Click(object sender, EventArgs e)
        {
        }

        private void ShipDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            Ship selected = (Ship)ShipDropDown.SelectedItem;
            ShipId.Text = Convert.ToString(selected.Id);
            ShipName.Text = Convert.ToString(selected.ShipName);
            ShipHeight.Text = Convert.ToString(selected.Height + "m");
            ShipLength.Text = Convert.ToString(selected.Length + "m");
            ShipBeam.Text = Convert.ToString(selected.Beam + "m");
            ShipCargoCapacity.Text = Convert.ToString(selected.CargoCapacity);
            ShipPowerPlant.Text = Convert.ToString(selected.PowerPlant);
            ShipPowerCount.Text = Convert.ToString(selected.PowerCount);
            ShipClass.Text = Convert.ToString(selected.Class);
        }

        private void OrgDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            Organisation selected = (Organisation)OrgDropDown.SelectedItem;
            OrgId.Text = Convert.ToString(selected.Id);
            OrgAdminUserId.Text = Convert.ToString(selected.AdminUserId);
            OrgStatusId.Text = Convert.ToString(selected.StatusId);
            OrgUserCount.Text = Convert.ToString(selected.UserCount);
            OrgDomain.Text = Convert.ToString(selected.Domain);
        }
    }
}
