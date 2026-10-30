namespace DVLD_Presentation.Applications.Local_Driving_License_Applications
{
    partial class frmIssueDriverLicenseForFirstTime
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIssueDriverLicenseForFirstTime));
            this.ctrlLocalDrivingLicenseApplicationCard1 = new DVLD_Presentation.Applications.Local_Driving_License_Applications.ctrlLocalDrivingLicenseApplicationCard();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ctrlCloseButton1 = new DVLD_Presentation.ctrlCloseButton();
            this.btnIssueLicense = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblFees = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ctrlLocalDrivingLicenseApplicationCard1
            // 
            this.ctrlLocalDrivingLicenseApplicationCard1.BackColor = System.Drawing.Color.White;
            this.ctrlLocalDrivingLicenseApplicationCard1.Location = new System.Drawing.Point(12, 26);
            this.ctrlLocalDrivingLicenseApplicationCard1.Name = "ctrlLocalDrivingLicenseApplicationCard1";
            this.ctrlLocalDrivingLicenseApplicationCard1.Size = new System.Drawing.Size(967, 402);
            this.ctrlLocalDrivingLicenseApplicationCard1.TabIndex = 2;
            // 
            // txtNotes
            // 
            this.txtNotes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtNotes.Location = new System.Drawing.Point(146, 481);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(825, 144);
            this.txtNotes.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::DVLD_Presentation.Properties.Resources.Notes_32;
            this.pictureBox2.Location = new System.Drawing.Point(108, 481);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 32);
            this.pictureBox2.TabIndex = 105;
            this.pictureBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 485);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 104;
            this.label3.Text = "Notes:";
            // 
            // ctrlCloseButton1
            // 
            this.ctrlCloseButton1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ctrlCloseButton1.Image = ((System.Drawing.Image)(resources.GetObject("ctrlCloseButton1.Image")));
            this.ctrlCloseButton1.Location = new System.Drawing.Point(652, 647);
            this.ctrlCloseButton1.Name = "ctrlCloseButton1";
            this.ctrlCloseButton1.Size = new System.Drawing.Size(152, 50);
            this.ctrlCloseButton1.TabIndex = 107;
            this.ctrlCloseButton1.Text = "ctrlCloseButton1";
            this.ctrlCloseButton1.UseVisualStyleBackColor = true;
            // 
            // btnIssueLicense
            // 
            this.btnIssueLicense.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnIssueLicense.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIssueLicense.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F);
            this.btnIssueLicense.Image = global::DVLD_Presentation.Properties.Resources.IssueDrivingLicense_32;
            this.btnIssueLicense.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIssueLicense.Location = new System.Drawing.Point(819, 647);
            this.btnIssueLicense.Name = "btnIssueLicense";
            this.btnIssueLicense.Size = new System.Drawing.Size(152, 50);
            this.btnIssueLicense.TabIndex = 108;
            this.btnIssueLicense.Text = "Issue";
            this.btnIssueLicense.UseVisualStyleBackColor = true;
            this.btnIssueLicense.Click += new System.EventHandler(this.btnIssueLicense_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLD_Presentation.Properties.Resources.money_32;
            this.pictureBox1.Location = new System.Drawing.Point(108, 433);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.TabIndex = 110;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 437);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 109;
            this.label1.Text = "Fees:";
            // 
            // lblFees
            // 
            this.lblFees.AutoSize = true;
            this.lblFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblFees.Location = new System.Drawing.Point(146, 437);
            this.lblFees.Name = "lblFees";
            this.lblFees.Size = new System.Drawing.Size(61, 20);
            this.lblFees.TabIndex = 111;
            this.lblFees.Text = "[????]";
            // 
            // frmIssueDriverLicenseForFirstTime
            // 
            this.AcceptButton = this.btnIssueLicense;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.ctrlCloseButton1;
            this.ClientSize = new System.Drawing.Size(998, 714);
            this.Controls.Add(this.lblFees);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnIssueLicense);
            this.Controls.Add(this.ctrlCloseButton1);
            this.Controls.Add(this.txtNotes);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ctrlLocalDrivingLicenseApplicationCard1);
            this.Name = "frmIssueDriverLicenseForFirstTime";
            this.Text = "Issue Driver License For The First Time";
            this.Load += new System.EventHandler(this.frmIssueDriverLicenseForFirstTime_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ctrlLocalDrivingLicenseApplicationCard ctrlLocalDrivingLicenseApplicationCard1;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
        private ctrlCloseButton ctrlCloseButton1;
        private System.Windows.Forms.Button btnIssueLicense;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblFees;
    }
}