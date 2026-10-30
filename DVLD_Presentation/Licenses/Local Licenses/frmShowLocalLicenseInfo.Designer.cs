namespace DVLD_Presentation.Licenses.Local_Licenses
{
    partial class frmShowLocalLicenseInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmShowLocalLicenseInfo));
            this.ctrlTitle1 = new DVLD_Presentation.Global_Controls.ctrlTitle();
            this.pbHeader = new System.Windows.Forms.PictureBox();
            this.ctrlDriverLocalLicenseCard1 = new DVLD_Presentation.Licenses.Local_Licenses.ctrlLocalLicenseCard();
            this.ctrlCloseButton1 = new DVLD_Presentation.ctrlCloseButton();
            ((System.ComponentModel.ISupportInitialize)(this.pbHeader)).BeginInit();
            this.SuspendLayout();
            // 
            // ctrlTitle1
            // 
            this.ctrlTitle1.Location = new System.Drawing.Point(193, 155);
            this.ctrlTitle1.Name = "ctrlTitle1";
            this.ctrlTitle1.Size = new System.Drawing.Size(605, 54);
            this.ctrlTitle1.TabIndex = 0;
            this.ctrlTitle1.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.ctrlTitle1.TitleText = "Driver License Info";
            // 
            // pbHeader
            // 
            this.pbHeader.Image = global::DVLD_Presentation.Properties.Resources.LicenseView_400;
            this.pbHeader.Location = new System.Drawing.Point(408, 12);
            this.pbHeader.Name = "pbHeader";
            this.pbHeader.Size = new System.Drawing.Size(175, 137);
            this.pbHeader.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbHeader.TabIndex = 1;
            this.pbHeader.TabStop = false;
            // 
            // ctrlDriverLocalLicenseCard1
            // 
            this.ctrlDriverLocalLicenseCard1.BackColor = System.Drawing.Color.White;
            this.ctrlDriverLocalLicenseCard1.Location = new System.Drawing.Point(10, 227);
            this.ctrlDriverLocalLicenseCard1.Name = "ctrlDriverLocalLicenseCard1";
            this.ctrlDriverLocalLicenseCard1.Size = new System.Drawing.Size(971, 382);
            this.ctrlDriverLocalLicenseCard1.TabIndex = 2;
            // 
            // ctrlCloseButton1
            // 
            this.ctrlCloseButton1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ctrlCloseButton1.Image = ((System.Drawing.Image)(resources.GetObject("ctrlCloseButton1.Image")));
            this.ctrlCloseButton1.Location = new System.Drawing.Point(806, 608);
            this.ctrlCloseButton1.Name = "ctrlCloseButton1";
            this.ctrlCloseButton1.Size = new System.Drawing.Size(166, 48);
            this.ctrlCloseButton1.TabIndex = 3;
            this.ctrlCloseButton1.Text = "ctrlCloseButton1";
            this.ctrlCloseButton1.UseVisualStyleBackColor = true;
            // 
            // frmShowLocalLicenseInfo
            // 
            this.AcceptButton = this.ctrlCloseButton1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.ctrlCloseButton1;
            this.ClientSize = new System.Drawing.Size(993, 668);
            this.Controls.Add(this.ctrlCloseButton1);
            this.Controls.Add(this.ctrlDriverLocalLicenseCard1);
            this.Controls.Add(this.pbHeader);
            this.Controls.Add(this.ctrlTitle1);
            this.Name = "frmShowLocalLicenseInfo";
            this.Text = "License Details";
            ((System.ComponentModel.ISupportInitialize)(this.pbHeader)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Global_Controls.ctrlTitle ctrlTitle1;
        private System.Windows.Forms.PictureBox pbHeader;
        private ctrlLocalLicenseCard ctrlDriverLocalLicenseCard1;
        private ctrlCloseButton ctrlCloseButton1;
    }
}