using System;
using System.Collections.Generic;
using System.Net;
using System.Windows.Forms;
using DataDelivery.Classes;
using DataDelivery;
// ReSharper disable ConvertToAutoProperty

namespace windowsDesktopClient
{
    public partial class Home : Form
    {
        
        public Home()
        {
            InitializeComponent();
            PopulateLists();
        }
        
        protected void PopulateLists()
        {

            Global.ListOfShips = Common.LoadData<List<Ship>>(GetCalls.ListOfShips);
            foreach (var item in Global.ListOfShips)
            {
                ShipDropDown.Items.Add(item);
            }
            ShipDropDown.DisplayMember = "ShipName";

            Global.ListOfOrgs = Common.LoadData<List<Organization>>(GetCalls.ListOfOrgs);
            foreach (var item in Global.ListOfOrgs)
            {
                OrgDropDown.Items.Add(item);
            }
            OrgDropDown.DisplayMember = "Name";

            Global.ListOfUsers = Common.LoadData<List<User>>(GetCalls.ListOfUsers);
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

            ShipUsers.Clear();

            var usersWithShips = Common.LoadData<Ship>(GetCalls.IndividualShip,selected.Id);

            foreach (var user in usersWithShips.Users)
            {
                ShipUsers.AppendText(user.UserName + " ,");
            }
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
                User adminUser = Common.LoadData<User>(GetCalls.IndividualUser, selected.Admin_User_Id);
                OrgAdminUser.Text = adminUser.UserName;
            }
            catch (WebException)
            {
                const string messageBoxText = "Error fetching data from database";
                const string caption = "UOLTT Desktop Application";
                const MessageBoxButtons button = MessageBoxButtons.RetryCancel;

                MessageBox.Show(messageBoxText, caption, button);
            }
        }
    }

    /// <summary>
    /// Internally shared variables able to be populated elsewhere
    /// </summary>
    internal static class Global
    {
        private static List<Ship> _listOfShips = new List<Ship>();
        private static List<Organization> _listOfOrgs = new List<Organization>();
        private static List<User> _listOfUsers = new List<User>();

        internal static List<Ship> ListOfShips
        {
            get { return _listOfShips; }
            set { _listOfShips = value; }
        }

        internal static List<Organization> ListOfOrgs
        {
            get { return _listOfOrgs; }
            set { _listOfOrgs = value; }
        }

        internal static List<User> ListOfUsers
        {
            get { return _listOfUsers; }
            set { _listOfUsers = value; }
        }
    }
}
