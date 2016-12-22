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
            this.organisationButton = new System.Windows.Forms.Button();
            this.shipPanel.SuspendLayout();
            this.orgPanel.SuspendLayout();
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
            this.shipButton.Click += new System.EventHandler(this.Button1_Click);
            // 
            // shipPanel
            // 
            this.shipPanel.Controls.Add(this.titleShip);
            this.shipPanel.Location = new System.Drawing.Point(76, 91);
            this.shipPanel.Name = "shipPanel";
            this.shipPanel.Size = new System.Drawing.Size(406, 245);
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
            this.orgPanel.Location = new System.Drawing.Point(319, 91);
            this.orgPanel.Name = "orgPanel";
            this.orgPanel.Size = new System.Drawing.Size(406, 245);
            this.orgPanel.TabIndex = 3;
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
            // organisationButton
            // 
            this.organisationButton.Location = new System.Drawing.Point(208, 32);
            this.organisationButton.Name = "organisationButton";
            this.organisationButton.Size = new System.Drawing.Size(75, 23);
            this.organisationButton.TabIndex = 4;
            this.organisationButton.Text = "Orgs";
            this.organisationButton.UseVisualStyleBackColor = true;
            this.organisationButton.Click += new System.EventHandler(this.OrganisationButton_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 487);
            this.Controls.Add(this.organisationButton);
            this.Controls.Add(this.orgPanel);
            this.Controls.Add(this.shipPanel);
            this.Controls.Add(this.shipButton);
            this.Name = "Home";
            this.Text = "UOLTT Desktop Client - Home";
            this.shipPanel.ResumeLayout(false);
            this.shipPanel.PerformLayout();
            this.orgPanel.ResumeLayout(false);
            this.orgPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button shipButton;
        private System.Windows.Forms.Panel shipPanel;
        private System.Windows.Forms.Label titleShip;
        private System.Windows.Forms.Panel orgPanel;
        private System.Windows.Forms.Label titleOrg;
        private System.Windows.Forms.Button organisationButton;
    }
}

