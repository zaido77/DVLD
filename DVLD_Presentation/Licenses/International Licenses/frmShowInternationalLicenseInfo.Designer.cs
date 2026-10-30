namespace DVLD_Presentation.Licenses.International_Licenses
{
    partial class frmShowInternationalLicenseInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmShowInternationalLicenseInfo));
            this.ctrlTitle1 = new DVLD_Presentation.Global_Controls.ctrlTitle();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ctrlCloseButton1 = new DVLD_Presentation.ctrlCloseButton();
            this.pbHeader = new System.Windows.Forms.PictureBox();
            this.ctrlInternationalLicenseCard1 = new DVLD_Presentation.Licenses.International_Licenses.Controls.ctrlInternationalLicenseCard();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHeader)).BeginInit();
            this.SuspendLayout();
            // 
            // ctrlTitle1
            // 
            this.ctrlTitle1.Location = new System.Drawing.Point(58, 149);
            this.ctrlTitle1.Name = "ctrlTitle1";
            this.ctrlTitle1.Size = new System.Drawing.Size(863, 54);
            this.ctrlTitle1.TabIndex = 4;
            this.ctrlTitle1.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.ctrlTitle1.TitleText = "Driver International License Info";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLD_Presentation.Properties.Resources.International_32;
            this.pictureBox1.Location = new System.Drawing.Point(402, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(47, 39);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // ctrlCloseButton1
            // 
            this.ctrlCloseButton1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ctrlCloseButton1.Image = ((System.Drawing.Image)(resources.GetObject("ctrlCloseButton1.Image")));
            this.ctrlCloseButton1.Location = new System.Drawing.Point(799, 517);
            this.ctrlCloseButton1.Name = "ctrlCloseButton1";
            this.ctrlCloseButton1.Size = new System.Drawing.Size(166, 48);
            this.ctrlCloseButton1.TabIndex = 7;
            this.ctrlCloseButton1.Text = "ctrlCloseButton1";
            this.ctrlCloseButton1.UseVisualStyleBackColor = true;
            // 
            // pbHeader
            // 
            this.pbHeader.Image = global::DVLD_Presentation.Properties.Resources.LicenseView_400;
            this.pbHeader.Location = new System.Drawing.Point(402, 6);
            this.pbHeader.Name = "pbHeader";
            this.pbHeader.Size = new System.Drawing.Size(175, 137);
            this.pbHeader.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbHeader.TabIndex = 5;
            this.pbHeader.TabStop = false;
            // 
            // ctrlInternationalLicenseCard1
            // 
            this.ctrlInternationalLicenseCard1.BackColor = System.Drawing.Color.White;
            this.ctrlInternationalLicenseCard1.Location = new System.Drawing.Point(5, 218);
            this.ctrlInternationalLicenseCard1.Name = "ctrlInternationalLicenseCard1";
            this.ctrlInternationalLicenseCard1.Size = new System.Drawing.Size(969, 294);
            this.ctrlInternationalLicenseCard1.TabIndex = 9;
            // 
            // frmShowInternationalLicenseInfo
            // 
            this.AcceptButton = this.ctrlCloseButton1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.ctrlCloseButton1;
            this.ClientSize = new System.Drawing.Size(978, 587);
            this.Controls.Add(this.ctrlInternationalLicenseCard1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ctrlCloseButton1);
            this.Controls.Add(this.pbHeader);
            this.Controls.Add(this.ctrlTitle1);
            this.Name = "frmShowInternationalLicenseInfo";
            this.Text = "International License Details";
            this.Load += new System.EventHandler(this.frmShowInternationalLicenseInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHeader)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlCloseButton ctrlCloseButton1;
        private System.Windows.Forms.PictureBox pbHeader;
        private Global_Controls.ctrlTitle ctrlTitle1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Controls.ctrlInternationalLicenseCard ctrlInternationalLicenseCard1;
    }
}