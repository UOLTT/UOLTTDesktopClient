﻿namespace windowsDesktopClient
{
    partial class Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.shipButton = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.shipPage = new System.Windows.Forms.TabPage();
            this.ShipUsers = new System.Windows.Forms.ListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.ShipClass = new System.Windows.Forms.TextBox();
            this.ShipPowerCount = new System.Windows.Forms.TextBox();
            this.ShipPowerPlant = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ShipCargoCapacity = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ShipBeam = new System.Windows.Forms.TextBox();
            this.ShipLength = new System.Windows.Forms.TextBox();
            this.ShipHeight = new System.Windows.Forms.TextBox();
            this.ShipName = new System.Windows.Forms.TextBox();
            this.ShipId = new System.Windows.Forms.TextBox();
            this.ShipDropDown = new System.Windows.Forms.ComboBox();
            this.orgPage = new System.Windows.Forms.TabPage();
            this.label15 = new System.Windows.Forms.Label();
            this.OrgAdminUser = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.OrgDomain = new System.Windows.Forms.TextBox();
            this.OrgUserCount = new System.Windows.Forms.TextBox();
            this.OrgStatusId = new System.Windows.Forms.TextBox();
            this.OrgAdminUserId = new System.Windows.Forms.TextBox();
            this.OrgId = new System.Windows.Forms.TextBox();
            this.OrgDropDown = new System.Windows.Forms.ComboBox();
            this.userPage = new System.Windows.Forms.TabPage();
            this.UsersShips = new System.Windows.Forms.ListBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.UserOrganisation = new System.Windows.Forms.TextBox();
            this.UserGameHandle = new System.Windows.Forms.TextBox();
            this.UserName = new System.Windows.Forms.TextBox();
            this.UserId = new System.Windows.Forms.TextBox();
            this.UserDropDown = new System.Windows.Forms.ComboBox();
            this.formationPage = new System.Windows.Forms.TabPage();
            this.pricePage = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.shipPage.SuspendLayout();
            this.orgPage.SuspendLayout();
            this.userPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // shipButton
            // 
            this.shipButton.Location = new System.Drawing.Point(12, 12);
            this.shipButton.Name = "shipButton";
            this.shipButton.Size = new System.Drawing.Size(75, 23);
            this.shipButton.TabIndex = 0;
            this.shipButton.Text = "Update Data";
            this.shipButton.UseVisualStyleBackColor = true;
            this.shipButton.Click += new System.EventHandler(this.ShipButton_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.shipPage);
            this.tabControl1.Controls.Add(this.orgPage);
            this.tabControl1.Controls.Add(this.userPage);
            this.tabControl1.Controls.Add(this.formationPage);
            this.tabControl1.Controls.Add(this.pricePage);
            this.tabControl1.Location = new System.Drawing.Point(104, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(860, 611);
            this.tabControl1.TabIndex = 7;
            // 
            // shipPage
            // 
            this.shipPage.BackColor = System.Drawing.Color.LightGray;
            this.shipPage.Controls.Add(this.ShipUsers);
            this.shipPage.Controls.Add(this.label9);
            this.shipPage.Controls.Add(this.ShipClass);
            this.shipPage.Controls.Add(this.ShipPowerCount);
            this.shipPage.Controls.Add(this.ShipPowerPlant);
            this.shipPage.Controls.Add(this.label8);
            this.shipPage.Controls.Add(this.label7);
            this.shipPage.Controls.Add(this.label6);
            this.shipPage.Controls.Add(this.ShipCargoCapacity);
            this.shipPage.Controls.Add(this.label5);
            this.shipPage.Controls.Add(this.label4);
            this.shipPage.Controls.Add(this.label3);
            this.shipPage.Controls.Add(this.label2);
            this.shipPage.Controls.Add(this.label1);
            this.shipPage.Controls.Add(this.ShipBeam);
            this.shipPage.Controls.Add(this.ShipLength);
            this.shipPage.Controls.Add(this.ShipHeight);
            this.shipPage.Controls.Add(this.ShipName);
            this.shipPage.Controls.Add(this.ShipId);
            this.shipPage.Controls.Add(this.ShipDropDown);
            this.shipPage.Location = new System.Drawing.Point(4, 22);
            this.shipPage.Name = "shipPage";
            this.shipPage.Padding = new System.Windows.Forms.Padding(3);
            this.shipPage.Size = new System.Drawing.Size(852, 585);
            this.shipPage.TabIndex = 0;
            this.shipPage.Text = "Ships";
            // 
            // ShipUsers
            // 
            this.ShipUsers.FormattingEnabled = true;
            this.ShipUsers.Location = new System.Drawing.Point(20, 153);
            this.ShipUsers.Name = "ShipUsers";
            this.ShipUsers.Size = new System.Drawing.Size(637, 264);
            this.ShipUsers.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(186, 14);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Ship Class";
            // 
            // ShipClass
            // 
            this.ShipClass.Location = new System.Drawing.Point(248, 10);
            this.ShipClass.Name = "ShipClass";
            this.ShipClass.Size = new System.Drawing.Size(100, 20);
            this.ShipClass.TabIndex = 19;
            // 
            // ShipPowerCount
            // 
            this.ShipPowerCount.Location = new System.Drawing.Point(557, 87);
            this.ShipPowerCount.Name = "ShipPowerCount";
            this.ShipPowerCount.Size = new System.Drawing.Size(100, 20);
            this.ShipPowerCount.TabIndex = 18;
            // 
            // ShipPowerPlant
            // 
            this.ShipPowerPlant.Location = new System.Drawing.Point(557, 61);
            this.ShipPowerPlant.Name = "ShipPowerPlant";
            this.ShipPowerPlant.Size = new System.Drawing.Size(100, 20);
            this.ShipPowerPlant.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(473, 93);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Power Count";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(473, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Power Plant";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(473, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Cargo Capacity";
            // 
            // ShipCargoCapacity
            // 
            this.ShipCargoCapacity.Location = new System.Drawing.Point(557, 35);
            this.ShipCargoCapacity.Name = "ShipCargoCapacity";
            this.ShipCargoCapacity.Size = new System.Drawing.Size(100, 20);
            this.ShipCargoCapacity.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(229, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Beam";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(123, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Length";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Height";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(120, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Ship Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "ID";
            // 
            // ShipBeam
            // 
            this.ShipBeam.Location = new System.Drawing.Point(229, 93);
            this.ShipBeam.Name = "ShipBeam";
            this.ShipBeam.Size = new System.Drawing.Size(100, 20);
            this.ShipBeam.TabIndex = 7;
            // 
            // ShipLength
            // 
            this.ShipLength.Location = new System.Drawing.Point(123, 93);
            this.ShipLength.Name = "ShipLength";
            this.ShipLength.Size = new System.Drawing.Size(100, 20);
            this.ShipLength.TabIndex = 6;
            // 
            // ShipHeight
            // 
            this.ShipHeight.Location = new System.Drawing.Point(17, 93);
            this.ShipHeight.Name = "ShipHeight";
            this.ShipHeight.Size = new System.Drawing.Size(100, 20);
            this.ShipHeight.TabIndex = 5;
            // 
            // ShipName
            // 
            this.ShipName.Location = new System.Drawing.Point(123, 54);
            this.ShipName.Name = "ShipName";
            this.ShipName.Size = new System.Drawing.Size(100, 20);
            this.ShipName.TabIndex = 4;
            // 
            // ShipId
            // 
            this.ShipId.Location = new System.Drawing.Point(17, 54);
            this.ShipId.Name = "ShipId";
            this.ShipId.Size = new System.Drawing.Size(100, 20);
            this.ShipId.TabIndex = 3;
            // 
            // ShipDropDown
            // 
            this.ShipDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ShipDropDown.FormattingEnabled = true;
            this.ShipDropDown.Location = new System.Drawing.Point(6, 6);
            this.ShipDropDown.Name = "ShipDropDown";
            this.ShipDropDown.Size = new System.Drawing.Size(174, 21);
            this.ShipDropDown.TabIndex = 2;
            this.ShipDropDown.SelectedIndexChanged += new System.EventHandler(this.ShipDropDown_SelectedIndexChanged);
            // 
            // orgPage
            // 
            this.orgPage.Controls.Add(this.label15);
            this.orgPage.Controls.Add(this.OrgAdminUser);
            this.orgPage.Controls.Add(this.label10);
            this.orgPage.Controls.Add(this.label11);
            this.orgPage.Controls.Add(this.label12);
            this.orgPage.Controls.Add(this.label13);
            this.orgPage.Controls.Add(this.label14);
            this.orgPage.Controls.Add(this.OrgDomain);
            this.orgPage.Controls.Add(this.OrgUserCount);
            this.orgPage.Controls.Add(this.OrgStatusId);
            this.orgPage.Controls.Add(this.OrgAdminUserId);
            this.orgPage.Controls.Add(this.OrgId);
            this.orgPage.Controls.Add(this.OrgDropDown);
            this.orgPage.Location = new System.Drawing.Point(4, 22);
            this.orgPage.Name = "orgPage";
            this.orgPage.Padding = new System.Windows.Forms.Padding(3);
            this.orgPage.Size = new System.Drawing.Size(852, 585);
            this.orgPage.TabIndex = 1;
            this.orgPage.Text = "Organisations";
            this.orgPage.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(218, 47);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(56, 13);
            this.label15.TabIndex = 24;
            this.label15.Text = "Org Admin";
            // 
            // OrgAdminUser
            // 
            this.OrgAdminUser.Location = new System.Drawing.Point(221, 68);
            this.OrgAdminUser.Name = "OrgAdminUser";
            this.OrgAdminUser.Size = new System.Drawing.Size(100, 20);
            this.OrgAdminUser.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(218, 91);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Domain";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(112, 91);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "User Count";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 91);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 13);
            this.label12.TabIndex = 20;
            this.label12.Text = "Status ID";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(109, 47);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(75, 13);
            this.label13.TabIndex = 19;
            this.label13.Text = "Admin User ID";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 49);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(18, 13);
            this.label14.TabIndex = 18;
            this.label14.Text = "ID";
            // 
            // OrgDomain
            // 
            this.OrgDomain.Location = new System.Drawing.Point(218, 107);
            this.OrgDomain.Name = "OrgDomain";
            this.OrgDomain.Size = new System.Drawing.Size(124, 20);
            this.OrgDomain.TabIndex = 17;
            // 
            // OrgUserCount
            // 
            this.OrgUserCount.Location = new System.Drawing.Point(112, 107);
            this.OrgUserCount.Name = "OrgUserCount";
            this.OrgUserCount.Size = new System.Drawing.Size(100, 20);
            this.OrgUserCount.TabIndex = 16;
            // 
            // OrgStatusId
            // 
            this.OrgStatusId.Location = new System.Drawing.Point(6, 107);
            this.OrgStatusId.Name = "OrgStatusId";
            this.OrgStatusId.Size = new System.Drawing.Size(100, 20);
            this.OrgStatusId.TabIndex = 15;
            // 
            // OrgAdminUserId
            // 
            this.OrgAdminUserId.Location = new System.Drawing.Point(112, 68);
            this.OrgAdminUserId.Name = "OrgAdminUserId";
            this.OrgAdminUserId.Size = new System.Drawing.Size(100, 20);
            this.OrgAdminUserId.TabIndex = 14;
            // 
            // OrgId
            // 
            this.OrgId.Location = new System.Drawing.Point(6, 68);
            this.OrgId.Name = "OrgId";
            this.OrgId.Size = new System.Drawing.Size(100, 20);
            this.OrgId.TabIndex = 13;
            // 
            // OrgDropDown
            // 
            this.OrgDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.OrgDropDown.FormattingEnabled = true;
            this.OrgDropDown.Location = new System.Drawing.Point(6, 6);
            this.OrgDropDown.Name = "OrgDropDown";
            this.OrgDropDown.Size = new System.Drawing.Size(206, 21);
            this.OrgDropDown.TabIndex = 3;
            this.OrgDropDown.SelectedIndexChanged += new System.EventHandler(this.OrgDropDown_SelectedIndexChanged);
            // 
            // userPage
            // 
            this.userPage.Controls.Add(this.UsersShips);
            this.userPage.Controls.Add(this.label17);
            this.userPage.Controls.Add(this.label19);
            this.userPage.Controls.Add(this.label20);
            this.userPage.Controls.Add(this.label21);
            this.userPage.Controls.Add(this.UserOrganisation);
            this.userPage.Controls.Add(this.UserGameHandle);
            this.userPage.Controls.Add(this.UserName);
            this.userPage.Controls.Add(this.UserId);
            this.userPage.Controls.Add(this.UserDropDown);
            this.userPage.Location = new System.Drawing.Point(4, 22);
            this.userPage.Name = "userPage";
            this.userPage.Size = new System.Drawing.Size(852, 585);
            this.userPage.TabIndex = 3;
            this.userPage.Text = "Users";
            this.userPage.UseVisualStyleBackColor = true;
            // 
            // UsersShips
            // 
            this.UsersShips.FormattingEnabled = true;
            this.UsersShips.Location = new System.Drawing.Point(17, 150);
            this.UsersShips.Name = "UsersShips";
            this.UsersShips.Size = new System.Drawing.Size(637, 264);
            this.UsersShips.TabIndex = 35;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(230, 77);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(66, 13);
            this.label17.TabIndex = 32;
            this.label17.Text = "Organisation";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(18, 77);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(72, 13);
            this.label19.TabIndex = 30;
            this.label19.Text = "Game Handle";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(121, 33);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(60, 13);
            this.label20.TabIndex = 29;
            this.label20.Text = "User Name";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(18, 35);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(18, 13);
            this.label21.TabIndex = 28;
            this.label21.Text = "ID";
            // 
            // UserOrganisation
            // 
            this.UserOrganisation.Location = new System.Drawing.Point(230, 93);
            this.UserOrganisation.Name = "UserOrganisation";
            this.UserOrganisation.Size = new System.Drawing.Size(100, 20);
            this.UserOrganisation.TabIndex = 27;
            // 
            // UserGameHandle
            // 
            this.UserGameHandle.Location = new System.Drawing.Point(18, 93);
            this.UserGameHandle.Name = "UserGameHandle";
            this.UserGameHandle.Size = new System.Drawing.Size(187, 20);
            this.UserGameHandle.TabIndex = 25;
            // 
            // UserName
            // 
            this.UserName.Location = new System.Drawing.Point(124, 54);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(206, 20);
            this.UserName.TabIndex = 24;
            // 
            // UserId
            // 
            this.UserId.Location = new System.Drawing.Point(18, 54);
            this.UserId.Name = "UserId";
            this.UserId.Size = new System.Drawing.Size(100, 20);
            this.UserId.TabIndex = 23;
            // 
            // UserDropDown
            // 
            this.UserDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.UserDropDown.FormattingEnabled = true;
            this.UserDropDown.Location = new System.Drawing.Point(6, 6);
            this.UserDropDown.Name = "UserDropDown";
            this.UserDropDown.Size = new System.Drawing.Size(174, 21);
            this.UserDropDown.TabIndex = 22;
            this.UserDropDown.SelectedIndexChanged += new System.EventHandler(this.UserDropDown_SelectedIndexChanged);
            // 
            // formationPage
            // 
            this.formationPage.Location = new System.Drawing.Point(4, 22);
            this.formationPage.Name = "formationPage";
            this.formationPage.Size = new System.Drawing.Size(852, 585);
            this.formationPage.TabIndex = 4;
            this.formationPage.Text = "Formations";
            this.formationPage.UseVisualStyleBackColor = true;
            // 
            // pricePage
            // 
            this.pricePage.Location = new System.Drawing.Point(4, 22);
            this.pricePage.Name = "pricePage";
            this.pricePage.Size = new System.Drawing.Size(852, 585);
            this.pricePage.TabIndex = 2;
            this.pricePage.Text = "Prices";
            this.pricePage.UseVisualStyleBackColor = true;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(976, 635);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.shipButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Home";
            this.Text = "UOLTT Desktop Client";
            this.tabControl1.ResumeLayout(false);
            this.shipPage.ResumeLayout(false);
            this.shipPage.PerformLayout();
            this.orgPage.ResumeLayout(false);
            this.orgPage.PerformLayout();
            this.userPage.ResumeLayout(false);
            this.userPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button shipButton;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage shipPage;
        private System.Windows.Forms.TabPage orgPage;
        private System.Windows.Forms.TabPage pricePage;
        private System.Windows.Forms.ComboBox ShipDropDown;
        private System.Windows.Forms.TextBox ShipBeam;
        private System.Windows.Forms.TextBox ShipLength;
        private System.Windows.Forms.TextBox ShipHeight;
        private System.Windows.Forms.TextBox ShipName;
        private System.Windows.Forms.TextBox ShipId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ShipCargoCapacity;
        private System.Windows.Forms.TextBox ShipPowerCount;
        private System.Windows.Forms.TextBox ShipPowerPlant;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox ShipClass;
        private System.Windows.Forms.ComboBox OrgDropDown;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox OrgDomain;
        private System.Windows.Forms.TextBox OrgUserCount;
        private System.Windows.Forms.TextBox OrgStatusId;
        private System.Windows.Forms.TextBox OrgAdminUserId;
        private System.Windows.Forms.TextBox OrgId;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox OrgAdminUser;
        private System.Windows.Forms.TabPage userPage;
        private System.Windows.Forms.ListBox ShipUsers;
        private System.Windows.Forms.ListBox UsersShips;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox UserOrganisation;
        private System.Windows.Forms.TextBox UserGameHandle;
        private System.Windows.Forms.TextBox UserName;
        private System.Windows.Forms.TextBox UserId;
        private System.Windows.Forms.ComboBox UserDropDown;
        private System.Windows.Forms.TabPage formationPage;
    }
}

