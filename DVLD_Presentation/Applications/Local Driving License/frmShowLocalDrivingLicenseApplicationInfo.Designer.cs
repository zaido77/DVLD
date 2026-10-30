namespace DVLD_Presentation.Applications.Local_Driving_License_Applications
{
    partial class frmShowLocalDrivingLicenseApplicationInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmShowLocalDrivingLicenseApplicationInfo));
            this.ctrlLocalDrivingLicenseApplicationCard1 = new DVLD_Presentation.Applications.Local_Driving_License_Applications.ctrlLocalDrivingLicenseApplicationCard();
            this.ctrlCloseButton1 = new DVLD_Presentation.ctrlCloseButton();
            this.SuspendLayout();
            // 
            // ctrlLocalDrivingLicenseApplicationCard1
            // 
            this.ctrlLocalDrivingLicenseApplicationCard1.BackColor = System.Drawing.Color.White;
            this.ctrlLocalDrivingLicenseApplicationCard1.Location = new System.Drawing.Point(7, 22);
            this.ctrlLocalDrivingLicenseApplicationCard1.Name = "ctrlLocalDrivingLicenseApplicationCard1";
            this.ctrlLocalDrivingLicenseApplicationCard1.Size = new System.Drawing.Size(967, 402);
            this.ctrlLocalDrivingLicenseApplicationCard1.TabIndex = 0;
            // 
            // ctrlCloseButton1
            // 
            this.ctrlCloseButton1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ctrlCloseButton1.Image = ((System.Drawing.Image)(resources.GetObject("ctrlCloseButton1.Image")));
            this.ctrlCloseButton1.Location = new System.Drawing.Point(831, 426);
            this.ctrlCloseButton1.Name = "ctrlCloseButton1";
            this.ctrlCloseButton1.Size = new System.Drawing.Size(135, 40);
            this.ctrlCloseButton1.TabIndex = 1;
            this.ctrlCloseButton1.Text = "ctrlCloseButton1";
            this.ctrlCloseButton1.UseVisualStyleBackColor = true;
            // 
            // frmShowLocalDrivingLicenseApplicationInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.ctrlCloseButton1;
            this.ClientSize = new System.Drawing.Size(979, 482);
            this.Controls.Add(this.ctrlCloseButton1);
            this.Controls.Add(this.ctrlLocalDrivingLicenseApplicationCard1);
            this.Name = "frmShowLocalDrivingLicenseApplicationInfo";
            this.Text = "Local Driving License Application Details";
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlLocalDrivingLicenseApplicationCard ctrlLocalDrivingLicenseApplicationCard1;
        private ctrlCloseButton ctrlCloseButton1;
    }
}