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
using System.Windows;
using System.Windows.Forms;
using windowsDesktopClient.Classes;

namespace windowsDesktopClient
{
    internal static class Global
    {
        private static List<Ship> _listOfShips = new List<Ship>();
        private static List<Organization> _listOfOrgs = new List<Organization>();
        private static List<User> _listOfUsers = new List<User>();

        public static List<Ship> listOfShips
        {
            get { return _listOfShips; }
            set { _listOfShips = value; }
        }

        public static List<Organization> listOfOrgs
        {
            get { return _listOfOrgs; }
            set { _listOfOrgs = value; }
        }

        public static List<User> listOfUsers
        { 
            get { return _listOfUsers; }
            set { _listOfUsers = value; }
        }
    }

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

                string messageBoxText = "There Was an Error";
                string caption = "UOLTT Desktop Application";
                MessageBoxButtons button = MessageBoxButtons.OK;

                MessageBox.Show(messageBoxText, caption, button);

                throw;
            }
        }
        public Home()
        {
            InitializeComponent();
            PopulateLists();
        }
        
        protected void PopulateLists()
        {
            Global.listOfShips = JsonConvert.DeserializeObject<List<Ship>>(GET(ApiCalls.ShipList));
            foreach (var item in Global.listOfShips)
            {
                ShipDropDown.Items.Add(item);
            }
            ShipDropDown.DisplayMember = "ShipName";

            string jsonRaw = GET(ApiCalls.OrgList);
            Global.listOfOrgs = JsonConvert.DeserializeObject<List<Organization>>(jsonRaw);
            foreach (var item in Global.listOfOrgs)
            {
                OrgDropDown.Items.Add(item);
            }
            OrgDropDown.DisplayMember = "Name";
            Ship testShip = JsonConvert.DeserializeObject<Ship>(GET(ApiCalls.ShipIndividual + "69"));
            string json = GET(ApiCalls.UserIndividual + "2384");
            User testUser = JsonConvert.DeserializeObject<User>(json);
            foreach (var ship in testUser.Ships)
            {
                var banana = ship.ShipName;
            }
        }

        private void ShipButton_Click(object sender, EventArgs e)
        {
            PopulateLists();
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
            Organization selected = (Organization)OrgDropDown.SelectedItem;
            OrgId.Text = Convert.ToString(selected.Id);
            OrgAdminUserId.Text = Convert.ToString(selected.Admin_User_Id);
            OrgStatusId.Text = Convert.ToString(selected.Status_Id);
            OrgUserCount.Text = Convert.ToString(selected.User_Count);
            OrgDomain.Text = Convert.ToString(selected.Domain);
            try
            {
                string jsonUserRaw = GET(ApiCalls.UserIndividual + Convert.ToString(selected.Admin_User_Id));
                User adminUser = JsonConvert.DeserializeObject<User>(jsonUserRaw);
                OrgAdminUser.Text = adminUser.UserName;
            }
            catch (WebException)
            {
                string messageBoxText = "Error fetching data from database";
                string caption = "UOLTT Desktop Application";
                MessageBoxButtons button = MessageBoxButtons.RetryCancel;

                MessageBox.Show(messageBoxText, caption, button);
            }
        }
    }
}
