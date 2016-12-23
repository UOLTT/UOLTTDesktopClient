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
            this.orgButton = new System.Windows.Forms.Button();
            this.PriceButton = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.shipPage = new System.Windows.Forms.TabPage();
            this.orgPage = new System.Windows.Forms.TabPage();
            this.pricePage = new System.Windows.Forms.TabPage();
            this.ShipDropDown = new System.Windows.Forms.ComboBox();
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
            this.shipButton.Text = "Ships";
            this.shipButton.UseVisualStyleBackColor = true;
            this.shipButton.Click += new System.EventHandler(this.ShipButton_Click);
            // 
            // orgButton
            // 
            this.orgButton.Location = new System.Drawing.Point(12, 41);
            this.orgButton.Name = "orgButton";
            this.orgButton.Size = new System.Drawing.Size(75, 23);
            this.orgButton.TabIndex = 4;
            this.orgButton.Text = "Orgs";
            this.orgButton.UseVisualStyleBackColor = true;
            this.orgButton.Click += new System.EventHandler(this.OrgButton_Click);
            // 
            // PriceButton
            // 
            this.PriceButton.Location = new System.Drawing.Point(12, 74);
            this.PriceButton.Name = "PriceButton";
            this.PriceButton.Size = new System.Drawing.Size(75, 23);
            this.PriceButton.TabIndex = 5;
            this.PriceButton.Text = "Prices";
            this.PriceButton.UseVisualStyleBackColor = true;
            this.PriceButton.Click += new System.EventHandler(this.PriceButton_Click);
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
            this.shipPage.Controls.Add(this.ShipDropDown);
            this.shipPage.Location = new System.Drawing.Point(4, 22);
            this.shipPage.Name = "shipPage";
            this.shipPage.Padding = new System.Windows.Forms.Padding(3);
            this.shipPage.Size = new System.Drawing.Size(673, 437);
            this.shipPage.TabIndex = 0;
            this.shipPage.Text = "Ships";
            this.shipPage.UseVisualStyleBackColor = true;
            // 
            // orgPage
            // 
            this.orgPage.Location = new System.Drawing.Point(4, 22);
            this.orgPage.Name = "orgPage";
            this.orgPage.Padding = new System.Windows.Forms.Padding(3);
            this.orgPage.Size = new System.Drawing.Size(553, 437);
            this.orgPage.TabIndex = 1;
            this.orgPage.Text = "Organisations";
            this.orgPage.UseVisualStyleBackColor = true;
            // 
            // pricePage
            // 
            this.pricePage.Location = new System.Drawing.Point(4, 22);
            this.pricePage.Name = "pricePage";
            this.pricePage.Size = new System.Drawing.Size(192, 74);
            this.pricePage.TabIndex = 2;
            this.pricePage.Text = "Prices";
            this.pricePage.UseVisualStyleBackColor = true;
            // 
            // ShipDropDown
            // 
            this.ShipDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ShipDropDown.FormattingEnabled = true;
            this.ShipDropDown.Location = new System.Drawing.Point(17, 9);
            this.ShipDropDown.Name = "ShipDropDown";
            this.ShipDropDown.Size = new System.Drawing.Size(121, 21);
            this.ShipDropDown.TabIndex = 2;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 487);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.orgButton);
            this.Controls.Add(this.shipButton);
            this.Controls.Add(this.PriceButton);
            this.Name = "Home";
            this.Text = "UOLTT Desktop Client - Home";
            this.tabControl1.ResumeLayout(false);
            this.shipPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button shipButton;
        private System.Windows.Forms.Button orgButton;
        private System.Windows.Forms.Button PriceButton;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage shipPage;
        private System.Windows.Forms.TabPage orgPage;
        private System.Windows.Forms.TabPage pricePage;
        private System.Windows.Forms.ComboBox ShipDropDown;
    }
}

