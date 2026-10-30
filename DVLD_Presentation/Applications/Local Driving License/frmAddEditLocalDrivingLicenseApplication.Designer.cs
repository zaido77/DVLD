namespace DVLD_Presentation.Applications.Local_Driving_License_Applications
{
    partial class frmAddEditLocalDrivingLicenseApplication
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddEditLocalDrivingLicenseApplication));
            this.tcLocalDLApplicationInfo = new System.Windows.Forms.TabControl();
            this.tabPersonalInfo = new System.Windows.Forms.TabPage();
            this.btnPersonalInfoNext = new System.Windows.Forms.Button();
            this.ctrlPersonCardWithFilter1 = new DVLD_Presentation.People.Controls.ctrlPersonCardWithFilter();
            this.tabApplicationInfo = new System.Windows.Forms.TabPage();
            this.cbLicenseClass = new System.Windows.Forms.ComboBox();
            this.lblCreatedBy = new System.Windows.Forms.Label();
            this.lblApplicationFees = new System.Windows.Forms.Label();
            this.lblApplicationDate = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblLocalDLApplicationID = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ctrlTitle1 = new DVLD_Presentation.Global_Controls.ctrlTitle();
            this.btnSave = new System.Windows.Forms.Button();
            this.ctrlCloseButton1 = new DVLD_Presentation.ctrlCloseButton();
            this.tcLocalDLApplicationInfo.SuspendLayout();
            this.tabPersonalInfo.SuspendLayout();
            this.tabApplicationInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // tcLocalDLApplicationInfo
            // 
            this.tcLocalDLApplicationInfo.Controls.Add(this.tabPersonalInfo);
            this.tcLocalDLApplicationInfo.Controls.Add(this.tabApplicationInfo);
            this.tcLocalDLApplicationInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tcLocalDLApplicationInfo.Location = new System.Drawing.Point(21, 114);
            this.tcLocalDLApplicationInfo.Name = "tcLocalDLApplicationInfo";
            this.tcLocalDLApplicationInfo.SelectedIndex = 0;
            this.tcLocalDLApplicationInfo.Size = new System.Drawing.Size(1002, 551);
            this.tcLocalDLApplicationInfo.TabIndex = 5;
            // 
            // tabPersonalInfo
            // 
            this.tabPersonalInfo.BackColor = System.Drawing.Color.White;
            this.tabPersonalInfo.Controls.Add(this.btnPersonalInfoNext);
            this.tabPersonalInfo.Controls.Add(this.ctrlPersonCardWithFilter1);
            this.tabPersonalInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.tabPersonalInfo.Location = new System.Drawing.Point(4, 29);
            this.tabPersonalInfo.Name = "tabPersonalInfo";
            this.tabPersonalInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabPersonalInfo.Size = new System.Drawing.Size(994, 518);
            this.tabPersonalInfo.TabIndex = 0;
            this.tabPersonalInfo.Text = "Personal Info";
            // 
            // btnPersonalInfoNext
            // 
            this.btnPersonalInfoNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPersonalInfoNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnPersonalInfoNext.Image = global::DVLD_Presentation.Properties.Resources.Next_32;
            this.btnPersonalInfoNext.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPersonalInfoNext.Location = new System.Drawing.Point(816, 467);
            this.btnPersonalInfoNext.Name = "btnPersonalInfoNext";
            this.btnPersonalInfoNext.Size = new System.Drawing.Size(156, 43);
            this.btnPersonalInfoNext.TabIndex = 70;
            this.btnPersonalInfoNext.Text = "Next";
            this.btnPersonalInfoNext.UseVisualStyleBackColor = true;
            this.btnPersonalInfoNext.Click += new System.EventHandler(this.btnPersonalInfoNext_Click);
            // 
            // ctrlPersonCardWithFilter1
            // 
            this.ctrlPersonCardWithFilter1.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ctrlPersonCardWithFilter1.BackColor = System.Drawing.Color.White;
            this.ctrlPersonCardWithFilter1.FilterEnabled = true;
            this.ctrlPersonCardWithFilter1.Location = new System.Drawing.Point(12, 23);
            this.ctrlPersonCardWithFilter1.Name = "ctrlPersonCardWithFilter1";
            this.ctrlPersonCardWithFilter1.ShowAddPerson = true;
            this.ctrlPersonCardWithFilter1.Size = new System.Drawing.Size(973, 440);
            this.ctrlPersonCardWithFilter1.TabIndex = 1;
            // 
            // tabApplicationInfo
            // 
            this.tabApplicationInfo.BackColor = System.Drawing.Color.White;
            this.tabApplicationInfo.Controls.Add(this.cbLicenseClass);
            this.tabApplicationInfo.Controls.Add(this.lblCreatedBy);
            this.tabApplicationInfo.Controls.Add(this.lblApplicationFees);
            this.tabApplicationInfo.Controls.Add(this.lblApplicationDate);
            this.tabApplicationInfo.Controls.Add(this.pictureBox5);
            this.tabApplicationInfo.Controls.Add(this.label5);
            this.tabApplicationInfo.Controls.Add(this.lblLocalDLApplicationID);
            this.tabApplicationInfo.Controls.Add(this.pictureBox4);
            this.tabApplicationInfo.Controls.Add(this.label4);
            this.tabApplicationInfo.Controls.Add(this.pictureBox2);
            this.tabApplicationInfo.Controls.Add(this.label3);
            this.tabApplicationInfo.Controls.Add(this.pictureBox1);
            this.tabApplicationInfo.Controls.Add(this.label1);
            this.tabApplicationInfo.Controls.Add(this.pictureBox3);
            this.tabApplicationInfo.Controls.Add(this.label2);
            this.tabApplicationInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.tabApplicationInfo.Location = new System.Drawing.Point(4, 29);
            this.tabApplicationInfo.Name = "tabApplicationInfo";
            this.tabApplicationInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabApplicationInfo.Size = new System.Drawing.Size(994, 518);
            this.tabApplicationInfo.TabIndex = 1;
            this.tabApplicationInfo.Text = "Application Info";
            // 
            // cbLicenseClass
            // 
            this.cbLicenseClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLicenseClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbLicenseClass.FormattingEnabled = true;
            this.cbLicenseClass.Location = new System.Drawing.Point(330, 157);
            this.cbLicenseClass.Name = "cbLicenseClass";
            this.cbLicenseClass.Size = new System.Drawing.Size(305, 28);
            this.cbLicenseClass.TabIndex = 96;
            // 
            // lblCreatedBy
            // 
            this.lblCreatedBy.AutoSize = true;
            this.lblCreatedBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreatedBy.Location = new System.Drawing.Point(326, 245);
            this.lblCreatedBy.Name = "lblCreatedBy";
            this.lblCreatedBy.Size = new System.Drawing.Size(51, 20);
            this.lblCreatedBy.TabIndex = 95;
            this.lblCreatedBy.Text = "[???]";
            // 
            // lblApplicationFees
            // 
            this.lblApplicationFees.AutoSize = true;
            this.lblApplicationFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApplicationFees.Location = new System.Drawing.Point(326, 203);
            this.lblApplicationFees.Name = "lblApplicationFees";
            this.lblApplicationFees.Size = new System.Drawing.Size(51, 20);
            this.lblApplicationFees.TabIndex = 94;
            this.lblApplicationFees.Text = "[???]";
            // 
            // lblApplicationDate
            // 
            this.lblApplicationDate.AutoSize = true;
            this.lblApplicationDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApplicationDate.Location = new System.Drawing.Point(326, 117);
            this.lblApplicationDate.Name = "lblApplicationDate";
            this.lblApplicationDate.Size = new System.Drawing.Size(51, 20);
            this.lblApplicationDate.TabIndex = 93;
            this.lblApplicationDate.Text = "[???]";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::DVLD_Presentation.Properties.Resources.User_32__2;
            this.pictureBox5.Location = new System.Drawing.Point(277, 237);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(32, 32);
            this.pictureBox5.TabIndex = 92;
            this.pictureBox5.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(83, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 20);
            this.label5.TabIndex = 91;
            this.label5.Text = "Created By:";
            // 
            // lblLocalDLApplicationID
            // 
            this.lblLocalDLApplicationID.AutoSize = true;
            this.lblLocalDLApplicationID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocalDLApplicationID.Location = new System.Drawing.Point(326, 72);
            this.lblLocalDLApplicationID.Name = "lblLocalDLApplicationID";
            this.lblLocalDLApplicationID.Size = new System.Drawing.Size(51, 20);
            this.lblLocalDLApplicationID.TabIndex = 89;
            this.lblLocalDLApplicationID.Text = "[???]";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::DVLD_Presentation.Properties.Resources.Number_32;
            this.pictureBox4.Location = new System.Drawing.Point(277, 66);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(32, 32);
            this.pictureBox4.TabIndex = 88;
            this.pictureBox4.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(83, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 20);
            this.label4.TabIndex = 87;
            this.label4.Text = "D.L.Application ID:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::DVLD_Presentation.Properties.Resources.money_32;
            this.pictureBox2.Location = new System.Drawing.Point(277, 195);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 32);
            this.pictureBox2.TabIndex = 86;
            this.pictureBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(83, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 20);
            this.label3.TabIndex = 85;
            this.label3.Text = "Application Fees:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLD_Presentation.Properties.Resources.License_Type_32;
            this.pictureBox1.Location = new System.Drawing.Point(277, 152);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.TabIndex = 84;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(83, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 20);
            this.label1.TabIndex = 83;
            this.label1.Text = "License Class:";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::DVLD_Presentation.Properties.Resources.Calendar_32;
            this.pictureBox3.Location = new System.Drawing.Point(277, 109);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(32, 32);
            this.pictureBox3.TabIndex = 82;
            this.pictureBox3.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(83, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 20);
            this.label2.TabIndex = 81;
            this.label2.Text = "Application Date:";
            // 
            // ctrlTitle1
            // 
            this.ctrlTitle1.Location = new System.Drawing.Point(39, 33);
            this.ctrlTitle1.Name = "ctrlTitle1";
            this.ctrlTitle1.Size = new System.Drawing.Size(960, 54);
            this.ctrlTitle1.TabIndex = 6;
            this.ctrlTitle1.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.ctrlTitle1.TitleText = "New Local Driving License Application";
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnSave.Image = global::DVLD_Presentation.Properties.Resources.Save_32;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(877, 672);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(142, 46);
            this.btnSave.TabIndex = 70;
            this.btnSave.Text = " Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // ctrlCloseButton1
            // 
            this.ctrlCloseButton1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ctrlCloseButton1.Image = ((System.Drawing.Image)(resources.GetObject("ctrlCloseButton1.Image")));
            this.ctrlCloseButton1.Location = new System.Drawing.Point(728, 672);
            this.ctrlCloseButton1.Name = "ctrlCloseButton1";
            this.ctrlCloseButton1.Size = new System.Drawing.Size(142, 46);
            this.ctrlCloseButton1.TabIndex = 71;
            // 
            // frmAddEditLocalDrivingLicenseApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.ctrlCloseButton1;
            this.ClientSize = new System.Drawing.Size(1043, 730);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.ctrlCloseButton1);
            this.Controls.Add(this.ctrlTitle1);
            this.Controls.Add(this.tcLocalDLApplicationInfo);
            this.Name = "frmAddEditLocalDrivingLicenseApplication";
            this.Text = "Add / Edit Local Driving License Application";
            this.Activated += new System.EventHandler(this.frmAddEditLocalDrivingLicenseApplication_Activated);
            this.Load += new System.EventHandler(this.frmAddEditLocalDrivingLicenseApplication_Load);
            this.tcLocalDLApplicationInfo.ResumeLayout(false);
            this.tabPersonalInfo.ResumeLayout(false);
            this.tabApplicationInfo.ResumeLayout(false);
            this.tabApplicationInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcLocalDLApplicationInfo;
        private System.Windows.Forms.TabPage tabPersonalInfo;
        private System.Windows.Forms.Button btnPersonalInfoNext;
        private People.Controls.ctrlPersonCardWithFilter ctrlPersonCardWithFilter1;
        private System.Windows.Forms.TabPage tabApplicationInfo;
        private System.Windows.Forms.Label lblLocalDLApplicationID;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label2;
        private Global_Controls.ctrlTitle ctrlTitle1;
        private System.Windows.Forms.Button btnSave;
        private ctrlCloseButton ctrlCloseButton1;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblCreatedBy;
        private System.Windows.Forms.Label lblApplicationFees;
        private System.Windows.Forms.Label lblApplicationDate;
        private System.Windows.Forms.ComboBox cbLicenseClass;
    }
}