namespace DVLD_Presentation.Licenses.Detained_Licenses
{
    partial class frmDetainLicense
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDetainLicense));
            this.llShowLicensesHistory = new System.Windows.Forms.LinkLabel();
            this.btnDetainLicense = new System.Windows.Forms.Button();
            this.ctrlCloseButton1 = new DVLD_Presentation.ctrlCloseButton();
            this.lblCreatedBy = new System.Windows.Forms.Label();
            this.lblLicenseID = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.label12 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblDetainDate = new System.Windows.Forms.Label();
            this.lblDetainID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.llShowLicenseInfo = new System.Windows.Forms.LinkLabel();
            this.gbApplicationInfo = new System.Windows.Forms.GroupBox();
            this.txtFineFees = new System.Windows.Forms.TextBox();
            this.ctrlLocalLicenseCardWithFilter1 = new DVLD_Presentation.Licenses.Controls.ctrlLocalLicenseCardWithFilter();
            this.ctrlTitle1 = new DVLD_Presentation.Global_Controls.ctrlTitle();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.gbApplicationInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // llShowLicensesHistory
            // 
            this.llShowLicensesHistory.AutoSize = true;
            this.llShowLicensesHistory.Enabled = false;
            this.llShowLicensesHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.llShowLicensesHistory.Location = new System.Drawing.Point(21, 729);
            this.llShowLicensesHistory.Name = "llShowLicensesHistory";
            this.llShowLicensesHistory.Size = new System.Drawing.Size(182, 20);
            this.llShowLicensesHistory.TabIndex = 119;
            this.llShowLicensesHistory.TabStop = true;
            this.llShowLicensesHistory.Text = "Show Licenses History";
            this.llShowLicensesHistory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llShowLicensesHistory_LinkClicked);
            // 
            // btnDetainLicense
            // 
            this.btnDetainLicense.Enabled = false;
            this.btnDetainLicense.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetainLicense.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F);
            this.btnDetainLicense.Image = global::DVLD_Presentation.Properties.Resources.Detain_32;
            this.btnDetainLicense.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDetainLicense.Location = new System.Drawing.Point(819, 729);
            this.btnDetainLicense.Name = "btnDetainLicense";
            this.btnDetainLicense.Size = new System.Drawing.Size(152, 45);
            this.btnDetainLicense.TabIndex = 117;
            this.btnDetainLicense.Text = "Detain";
            this.btnDetainLicense.UseVisualStyleBackColor = true;
            this.btnDetainLicense.Click += new System.EventHandler(this.btnDetainLicense_Click);
            // 
            // ctrlCloseButton1
            // 
            this.ctrlCloseButton1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ctrlCloseButton1.Image = ((System.Drawing.Image)(resources.GetObject("ctrlCloseButton1.Image")));
            this.ctrlCloseButton1.Location = new System.Drawing.Point(655, 729);
            this.ctrlCloseButton1.Name = "ctrlCloseButton1";
            this.ctrlCloseButton1.Size = new System.Drawing.Size(152, 45);
            this.ctrlCloseButton1.TabIndex = 116;
            this.ctrlCloseButton1.Text = "ctrlCloseButton1";
            this.ctrlCloseButton1.UseVisualStyleBackColor = true;
            // 
            // lblCreatedBy
            // 
            this.lblCreatedBy.AutoSize = true;
            this.lblCreatedBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblCreatedBy.Location = new System.Drawing.Point(735, 74);
            this.lblCreatedBy.Name = "lblCreatedBy";
            this.lblCreatedBy.Size = new System.Drawing.Size(61, 20);
            this.lblCreatedBy.TabIndex = 129;
            this.lblCreatedBy.Text = "[????]";
            // 
            // lblLicenseID
            // 
            this.lblLicenseID.AutoSize = true;
            this.lblLicenseID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblLicenseID.Location = new System.Drawing.Point(735, 38);
            this.lblLicenseID.Name = "lblLicenseID";
            this.lblLicenseID.Size = new System.Drawing.Size(61, 20);
            this.lblLicenseID.TabIndex = 125;
            this.lblLicenseID.Text = "[????]";
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::DVLD_Presentation.Properties.Resources.User_32__2;
            this.pictureBox6.Location = new System.Drawing.Point(697, 68);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(32, 32);
            this.pictureBox6.TabIndex = 123;
            this.pictureBox6.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(524, 74);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(109, 20);
            this.label10.TabIndex = 121;
            this.label10.Text = "Created By:";
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::DVLD_Presentation.Properties.Resources.LocalDriving_License;
            this.pictureBox7.Location = new System.Drawing.Point(697, 34);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(32, 32);
            this.pictureBox7.TabIndex = 118;
            this.pictureBox7.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(524, 38);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(106, 20);
            this.label12.TabIndex = 117;
            this.label12.Text = "License ID:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLD_Presentation.Properties.Resources.Number_32;
            this.pictureBox1.Location = new System.Drawing.Point(201, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.TabIndex = 116;
            this.pictureBox1.TabStop = false;
            // 
            // lblDetainDate
            // 
            this.lblDetainDate.AutoSize = true;
            this.lblDetainDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblDetainDate.Location = new System.Drawing.Point(239, 74);
            this.lblDetainDate.Name = "lblDetainDate";
            this.lblDetainDate.Size = new System.Drawing.Size(113, 20);
            this.lblDetainDate.TabIndex = 112;
            this.lblDetainDate.Text = "[??/??/????]";
            // 
            // lblDetainID
            // 
            this.lblDetainID.AutoSize = true;
            this.lblDetainID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblDetainID.Location = new System.Drawing.Point(239, 38);
            this.lblDetainID.Name = "lblDetainID";
            this.lblDetainID.Size = new System.Drawing.Size(61, 20);
            this.lblDetainID.TabIndex = 108;
            this.lblDetainID.Text = "[????]";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.TabIndex = 105;
            this.label1.Text = "Detain ID:";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::DVLD_Presentation.Properties.Resources.money_32;
            this.pictureBox3.Location = new System.Drawing.Point(201, 100);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(32, 32);
            this.pictureBox3.TabIndex = 109;
            this.pictureBox3.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 20);
            this.label4.TabIndex = 106;
            this.label4.Text = "Fine Fees:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::DVLD_Presentation.Properties.Resources.Calendar_32;
            this.pictureBox2.Location = new System.Drawing.Point(201, 66);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 32);
            this.pictureBox2.TabIndex = 103;
            this.pictureBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 20);
            this.label3.TabIndex = 102;
            this.label3.Text = "Detain Date:";
            // 
            // llShowLicenseInfo
            // 
            this.llShowLicenseInfo.AutoSize = true;
            this.llShowLicenseInfo.Enabled = false;
            this.llShowLicenseInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.llShowLicenseInfo.Location = new System.Drawing.Point(221, 729);
            this.llShowLicenseInfo.Name = "llShowLicenseInfo";
            this.llShowLicenseInfo.Size = new System.Drawing.Size(146, 20);
            this.llShowLicenseInfo.TabIndex = 118;
            this.llShowLicenseInfo.TabStop = true;
            this.llShowLicenseInfo.Text = "Show License Info";
            this.llShowLicenseInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llShowLicenseInfo_LinkClicked);
            // 
            // gbApplicationInfo
            // 
            this.gbApplicationInfo.Controls.Add(this.txtFineFees);
            this.gbApplicationInfo.Controls.Add(this.lblCreatedBy);
            this.gbApplicationInfo.Controls.Add(this.lblLicenseID);
            this.gbApplicationInfo.Controls.Add(this.pictureBox6);
            this.gbApplicationInfo.Controls.Add(this.label10);
            this.gbApplicationInfo.Controls.Add(this.pictureBox7);
            this.gbApplicationInfo.Controls.Add(this.label12);
            this.gbApplicationInfo.Controls.Add(this.pictureBox1);
            this.gbApplicationInfo.Controls.Add(this.lblDetainDate);
            this.gbApplicationInfo.Controls.Add(this.lblDetainID);
            this.gbApplicationInfo.Controls.Add(this.label1);
            this.gbApplicationInfo.Controls.Add(this.pictureBox3);
            this.gbApplicationInfo.Controls.Add(this.label4);
            this.gbApplicationInfo.Controls.Add(this.pictureBox2);
            this.gbApplicationInfo.Controls.Add(this.label3);
            this.gbApplicationInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.gbApplicationInfo.Location = new System.Drawing.Point(20, 565);
            this.gbApplicationInfo.Name = "gbApplicationInfo";
            this.gbApplicationInfo.Size = new System.Drawing.Size(950, 149);
            this.gbApplicationInfo.TabIndex = 115;
            this.gbApplicationInfo.TabStop = false;
            this.gbApplicationInfo.Text = "Detain Info";
            // 
            // txtFineFees
            // 
            this.txtFineFees.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFineFees.Location = new System.Drawing.Point(243, 107);
            this.txtFineFees.Name = "txtFineFees";
            this.txtFineFees.Size = new System.Drawing.Size(109, 26);
            this.txtFineFees.TabIndex = 130;
            this.txtFineFees.Validating += new System.ComponentModel.CancelEventHandler(this.txtFineFees_Validating);
            // 
            // ctrlLocalLicenseCardWithFilter1
            // 
            this.ctrlLocalLicenseCardWithFilter1.BackColor = System.Drawing.Color.White;
            this.ctrlLocalLicenseCardWithFilter1.FilterEnabled = true;
            this.ctrlLocalLicenseCardWithFilter1.Location = new System.Drawing.Point(9, 76);
            this.ctrlLocalLicenseCardWithFilter1.Name = "ctrlLocalLicenseCardWithFilter1";
            this.ctrlLocalLicenseCardWithFilter1.Size = new System.Drawing.Size(970, 491);
            this.ctrlLocalLicenseCardWithFilter1.TabIndex = 114;
            this.ctrlLocalLicenseCardWithFilter1.LicenseSelected += new DVLD_Presentation.Licenses.Controls.ctrlLocalLicenseCardWithFilter.LicenseSelectedEventHandler(this.ctrlLocalLicenseCardWithFilter1_LicenseSelected);
            // 
            // ctrlTitle1
            // 
            this.ctrlTitle1.Location = new System.Drawing.Point(81, 17);
            this.ctrlTitle1.Name = "ctrlTitle1";
            this.ctrlTitle1.Size = new System.Drawing.Size(826, 54);
            this.ctrlTitle1.TabIndex = 113;
            this.ctrlTitle1.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.ctrlTitle1.TitleText = "Detain License";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmDetainLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.ctrlCloseButton1;
            this.ClientSize = new System.Drawing.Size(989, 790);
            this.Controls.Add(this.llShowLicensesHistory);
            this.Controls.Add(this.btnDetainLicense);
            this.Controls.Add(this.ctrlCloseButton1);
            this.Controls.Add(this.llShowLicenseInfo);
            this.Controls.Add(this.gbApplicationInfo);
            this.Controls.Add(this.ctrlLocalLicenseCardWithFilter1);
            this.Controls.Add(this.ctrlTitle1);
            this.Name = "frmDetainLicense";
            this.Text = "Detain License";
            this.Activated += new System.EventHandler(this.frmDetainLicense_Activated);
            this.Load += new System.EventHandler(this.frmDetainLicense_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.gbApplicationInfo.ResumeLayout(false);
            this.gbApplicationInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel llShowLicensesHistory;
        private System.Windows.Forms.Button btnDetainLicense;
        private ctrlCloseButton ctrlCloseButton1;
        private System.Windows.Forms.Label lblCreatedBy;
        private System.Windows.Forms.Label lblLicenseID;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblDetainDate;
        private System.Windows.Forms.Label lblDetainID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel llShowLicenseInfo;
        private System.Windows.Forms.GroupBox gbApplicationInfo;
        private Controls.ctrlLocalLicenseCardWithFilter ctrlLocalLicenseCardWithFilter1;
        private Global_Controls.ctrlTitle ctrlTitle1;
        private System.Windows.Forms.TextBox txtFineFees;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}