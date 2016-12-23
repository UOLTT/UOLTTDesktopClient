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
            this.shipPanel = new System.Windows.Forms.Panel();
            this.titleShip = new System.Windows.Forms.Label();
            this.orgPanel = new System.Windows.Forms.Panel();
            this.titleOrg = new System.Windows.Forms.Label();
            this.orgButton = new System.Windows.Forms.Button();
            this.PriceButton = new System.Windows.Forms.Button();
            this.pricePanel = new System.Windows.Forms.Panel();
            this.titlePrice = new System.Windows.Forms.Label();
            this.shipPanel.SuspendLayout();
            this.orgPanel.SuspendLayout();
            this.pricePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // shipButton
            // 
            this.shipButton.Location = new System.Drawing.Point(76, 32);
            this.shipButton.Name = "shipButton";
            this.shipButton.Size = new System.Drawing.Size(75, 23);
            this.shipButton.TabIndex = 0;
            this.shipButton.Text = "Ships";
            this.shipButton.UseVisualStyleBackColor = true;
            this.shipButton.Click += new System.EventHandler(this.ShipButton_Click);
            // 
            // shipPanel
            // 
            this.shipPanel.Controls.Add(this.titleShip);
            this.shipPanel.Location = new System.Drawing.Point(63, 91);
            this.shipPanel.Name = "shipPanel";
            this.shipPanel.Size = new System.Drawing.Size(649, 353);
            this.shipPanel.TabIndex = 1;
            // 
            // titleShip
            // 
            this.titleShip.AutoSize = true;
            this.titleShip.Location = new System.Drawing.Point(13, 9);
            this.titleShip.Name = "titleShip";
            this.titleShip.Size = new System.Drawing.Size(33, 13);
            this.titleShip.TabIndex = 0;
            this.titleShip.Text = "Ships";
            // 
            // orgPanel
            // 
            this.orgPanel.Controls.Add(this.titleOrg);
            this.orgPanel.Location = new System.Drawing.Point(113, 91);
            this.orgPanel.Name = "orgPanel";
            this.orgPanel.Size = new System.Drawing.Size(597, 353);
            this.orgPanel.TabIndex = 1;
            // 
            // titleOrg
            // 
            this.titleOrg.AutoSize = true;
            this.titleOrg.Location = new System.Drawing.Point(14, 9);
            this.titleOrg.Name = "titleOrg";
            this.titleOrg.Size = new System.Drawing.Size(71, 13);
            this.titleOrg.TabIndex = 0;
            this.titleOrg.Text = "Organisations";
            // 
            // orgButton
            // 
            this.orgButton.Location = new System.Drawing.Point(208, 32);
            this.orgButton.Name = "orgButton";
            this.orgButton.Size = new System.Drawing.Size(75, 23);
            this.orgButton.TabIndex = 4;
            this.orgButton.Text = "Orgs";
            this.orgButton.UseVisualStyleBackColor = true;
            this.orgButton.Click += new System.EventHandler(this.OrgButton_Click);
            // 
            // PriceButton
            // 
            this.PriceButton.Location = new System.Drawing.Point(341, 32);
            this.PriceButton.Name = "PriceButton";
            this.PriceButton.Size = new System.Drawing.Size(75, 23);
            this.PriceButton.TabIndex = 5;
            this.PriceButton.Text = "Prices";
            this.PriceButton.UseVisualStyleBackColor = true;
            this.PriceButton.Click += new System.EventHandler(this.PriceButton_Click);
            // 
            // pricePanel
            // 
            this.pricePanel.Controls.Add(this.titlePrice);
            this.pricePanel.Location = new System.Drawing.Point(165, 92);
            this.pricePanel.Name = "pricePanel";
            this.pricePanel.Size = new System.Drawing.Size(543, 353);
            this.pricePanel.TabIndex = 6;
            // 
            // titlePrice
            // 
            this.titlePrice.AutoSize = true;
            this.titlePrice.Location = new System.Drawing.Point(29, 9);
            this.titlePrice.Name = "titlePrice";
            this.titlePrice.Size = new System.Drawing.Size(36, 13);
            this.titlePrice.TabIndex = 0;
            this.titlePrice.Text = "Prices";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 487);
            this.Controls.Add(this.pricePanel);
            this.Controls.Add(this.orgButton);
            this.Controls.Add(this.orgPanel);
            this.Controls.Add(this.shipPanel);
            this.Controls.Add(this.shipButton);
            this.Controls.Add(this.PriceButton);
            this.Name = "Home";
            this.Text = "UOLTT Desktop Client - Home";
            this.shipPanel.ResumeLayout(false);
            this.shipPanel.PerformLayout();
            this.orgPanel.ResumeLayout(false);
            this.orgPanel.PerformLayout();
            this.pricePanel.ResumeLayout(false);
            this.pricePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button shipButton;
        private System.Windows.Forms.Panel shipPanel;
        private System.Windows.Forms.Label titleShip;
        private System.Windows.Forms.Panel orgPanel;
        private System.Windows.Forms.Label titleOrg;
        private System.Windows.Forms.Button orgButton;
        private System.Windows.Forms.Button PriceButton;
        private System.Windows.Forms.Panel pricePanel;
        private System.Windows.Forms.Label titlePrice;
    }
}

