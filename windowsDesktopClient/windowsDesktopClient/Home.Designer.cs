namespace windowsDesktopClient
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
            this.shipButton = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.shipPage = new System.Windows.Forms.TabPage();
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
            this.pricePage = new System.Windows.Forms.TabPage();
            this.ShipCargoCapacity = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ShipPowerPlant = new System.Windows.Forms.TextBox();
            this.ShipPowerCount = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.ShipClass = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.shipPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // shipButton
            // 
            this.shipButton.Location = new System.Drawing.Point(12, 12);
            this.shipButton.Name = "shipButton";
            this.shipButton.Size = new System.Drawing.Size(75, 23);
            this.shipButton.TabIndex = 0;
            this.shipButton.Text = "Load Ships";
            this.shipButton.UseVisualStyleBackColor = true;
            this.shipButton.Click += new System.EventHandler(this.ShipButton_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.shipPage);
            this.tabControl1.Controls.Add(this.orgPage);
            this.tabControl1.Controls.Add(this.pricePage);
            this.tabControl1.Location = new System.Drawing.Point(104, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(681, 463);
            this.tabControl1.TabIndex = 7;
            // 
            // shipPage
            // 
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
            this.shipPage.Size = new System.Drawing.Size(673, 437);
            this.shipPage.TabIndex = 0;
            this.shipPage.Text = "Ships";
            this.shipPage.UseVisualStyleBackColor = true;
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
            this.ShipDropDown.Location = new System.Drawing.Point(17, 9);
            this.ShipDropDown.Name = "ShipDropDown";
            this.ShipDropDown.Size = new System.Drawing.Size(121, 21);
            this.ShipDropDown.TabIndex = 2;
            this.ShipDropDown.SelectedIndexChanged += new System.EventHandler(this.ShipDropDown_SelectedIndexChanged);
            // 
            // orgPage
            // 
            this.orgPage.Location = new System.Drawing.Point(4, 22);
            this.orgPage.Name = "orgPage";
            this.orgPage.Padding = new System.Windows.Forms.Padding(3);
            this.orgPage.Size = new System.Drawing.Size(673, 437);
            this.orgPage.TabIndex = 1;
            this.orgPage.Text = "Organisations";
            this.orgPage.UseVisualStyleBackColor = true;
            // 
            // pricePage
            // 
            this.pricePage.Location = new System.Drawing.Point(4, 22);
            this.pricePage.Name = "pricePage";
            this.pricePage.Size = new System.Drawing.Size(673, 437);
            this.pricePage.TabIndex = 2;
            this.pricePage.Text = "Prices";
            this.pricePage.UseVisualStyleBackColor = true;
            // 
            // ShipCargoCapacity
            // 
            this.ShipCargoCapacity.Location = new System.Drawing.Point(557, 35);
            this.ShipCargoCapacity.Name = "ShipCargoCapacity";
            this.ShipCargoCapacity.Size = new System.Drawing.Size(100, 20);
            this.ShipCargoCapacity.TabIndex = 13;
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(473, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Power Plant";
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
            // ShipPowerPlant
            // 
            this.ShipPowerPlant.Location = new System.Drawing.Point(557, 61);
            this.ShipPowerPlant.Name = "ShipPowerPlant";
            this.ShipPowerPlant.Size = new System.Drawing.Size(100, 20);
            this.ShipPowerPlant.TabIndex = 17;
            // 
            // ShipPowerCount
            // 
            this.ShipPowerCount.Location = new System.Drawing.Point(557, 87);
            this.ShipPowerCount.Name = "ShipPowerCount";
            this.ShipPowerCount.Size = new System.Drawing.Size(100, 20);
            this.ShipPowerCount.TabIndex = 18;
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
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 487);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.shipButton);
            this.Name = "Home";
            this.Text = "UOLTT Desktop Client";
            this.tabControl1.ResumeLayout(false);
            this.shipPage.ResumeLayout(false);
            this.shipPage.PerformLayout();
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
    }
}

