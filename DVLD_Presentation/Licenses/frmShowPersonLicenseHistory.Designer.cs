namespace DVLD_Presentation.Licenses
{
    partial class frmShowPersonLicenseHistory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmShowPersonLicenseHistory));
            this.ctrlPersonCardWithFilter1 = new DVLD_Presentation.People.Controls.ctrlPersonCardWithFilter();
            this.ctrlDriverLicenses1 = new DVLD_Presentation.Applications.Local_Driving_License_Applications.ctrlDriverLicenses();
            this.ctrlCloseButton1 = new DVLD_Presentation.ctrlCloseButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ctrlTitle1 = new DVLD_Presentation.Global_Controls.ctrlTitle();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ctrlPersonCardWithFilter1
            // 
            this.ctrlPersonCardWithFilter1.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ctrlPersonCardWithFilter1.BackColor = System.Drawing.Color.White;
            this.ctrlPersonCardWithFilter1.FilterEnabled = true;
            this.ctrlPersonCardWithFilter1.Location = new System.Drawing.Point(237, 71);
            this.ctrlPersonCardWithFilter1.Name = "ctrlPersonCardWithFilter1";
            this.ctrlPersonCardWithFilter1.ShowAddPerson = true;
            this.ctrlPersonCardWithFilter1.Size = new System.Drawing.Size(973, 440);
            this.ctrlPersonCardWithFilter1.TabIndex = 0;
            this.ctrlPersonCardWithFilter1.PersonSelected += new DVLD_Presentation.People.Controls.ctrlPersonCardWithFilter.PersonSelectedEventHandler(this.ctrlPersonCardWithFilter1_PersonSelected);
            // 
            // ctrlDriverLicenses1
            // 
            this.ctrlDriverLicenses1.BackColor = System.Drawing.Color.White;
            this.ctrlDriverLicenses1.Location = new System.Drawing.Point(13, 502);
            this.ctrlDriverLicenses1.Name = "ctrlDriverLicenses1";
            this.ctrlDriverLicenses1.Size = new System.Drawing.Size(1193, 387);
            this.ctrlDriverLicenses1.TabIndex = 3;
            // 
            // ctrlCloseButton1
            // 
            this.ctrlCloseButton1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ctrlCloseButton1.Image = ((System.Drawing.Image)(resources.GetObject("ctrlCloseButton1.Image")));
            this.ctrlCloseButton1.Location = new System.Drawing.Point(1020, 845);
            this.ctrlCloseButton1.Name = "ctrlCloseButton1";
            this.ctrlCloseButton1.Size = new System.Drawing.Size(176, 46);
            this.ctrlCloseButton1.TabIndex = 2;
            this.ctrlCloseButton1.Text = "ctrlCloseButton1";
            this.ctrlCloseButton1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLD_Presentation.Properties.Resources.PersonLicenseHistory_512;
            this.pictureBox1.Location = new System.Drawing.Point(9, 200);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(230, 230);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // ctrlTitle1
            // 
            this.ctrlTitle1.Location = new System.Drawing.Point(199, 22);
            this.ctrlTitle1.Name = "ctrlTitle1";
            this.ctrlTitle1.Size = new System.Drawing.Size(819, 54);
            this.ctrlTitle1.TabIndex = 5;
            this.ctrlTitle1.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.ctrlTitle1.TitleText = "License History";
            // 
            // frmShowPersonLicenseHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.ctrlCloseButton1;
            this.ClientSize = new System.Drawing.Size(1213, 900);
            this.Controls.Add(this.ctrlTitle1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ctrlCloseButton1);
            this.Controls.Add(this.ctrlPersonCardWithFilter1);
            this.Controls.Add(this.ctrlDriverLicenses1);
            this.Name = "frmShowPersonLicenseHistory";
            this.Text = "License History";
            this.Activated += new System.EventHandler(this.frmShowPersonLicenseHistory_Activated);
            this.Load += new System.EventHandler(this.frmShowPersonLicenseHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private People.Controls.ctrlPersonCardWithFilter ctrlPersonCardWithFilter1;
        private ctrlCloseButton ctrlCloseButton1;
        private Applications.Local_Driving_License_Applications.ctrlDriverLicenses ctrlDriverLicenses1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Global_Controls.ctrlTitle ctrlTitle1;
    }
}