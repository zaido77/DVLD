namespace DVLD_Presentation.Users
{
    partial class frmAddUpdateUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddUpdateUser));
            this.ctrlTitle1 = new DVLD_Presentation.Global_Controls.ctrlTitle();
            this.tcUserInfo = new System.Windows.Forms.TabControl();
            this.tabPersonalInfo = new System.Windows.Forms.TabPage();
            this.btnPersonalInfoNext = new System.Windows.Forms.Button();
            this.ctrlPersonCardWithFilter1 = new DVLD_Presentation.People.Controls.ctrlPersonCardWithFilter();
            this.tabLoginInfo = new System.Windows.Forms.TabPage();
            this.chkIsAcitve = new System.Windows.Forms.CheckBox();
            this.lblUserID = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.ctrlCloseButton1 = new DVLD_Presentation.ctrlCloseButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tcUserInfo.SuspendLayout();
            this.tabPersonalInfo.SuspendLayout();
            this.tabLoginInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // ctrlTitle1
            // 
            this.ctrlTitle1.Location = new System.Drawing.Point(130, 40);
            this.ctrlTitle1.Name = "ctrlTitle1";
            this.ctrlTitle1.Size = new System.Drawing.Size(767, 54);
            this.ctrlTitle1.TabIndex = 0;
            this.ctrlTitle1.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.ctrlTitle1.TitleText = "Add New User";
            // 
            // tcUserInfo
            // 
            this.tcUserInfo.Controls.Add(this.tabPersonalInfo);
            this.tcUserInfo.Controls.Add(this.tabLoginInfo);
            this.tcUserInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tcUserInfo.Location = new System.Drawing.Point(12, 109);
            this.tcUserInfo.Name = "tcUserInfo";
            this.tcUserInfo.SelectedIndex = 0;
            this.tcUserInfo.Size = new System.Drawing.Size(1002, 551);
            this.tcUserInfo.TabIndex = 4;
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
            // tabLoginInfo
            // 
            this.tabLoginInfo.BackColor = System.Drawing.Color.White;
            this.tabLoginInfo.Controls.Add(this.chkIsAcitve);
            this.tabLoginInfo.Controls.Add(this.lblUserID);
            this.tabLoginInfo.Controls.Add(this.pictureBox4);
            this.tabLoginInfo.Controls.Add(this.label4);
            this.tabLoginInfo.Controls.Add(this.txtConfirmPassword);
            this.tabLoginInfo.Controls.Add(this.pictureBox2);
            this.tabLoginInfo.Controls.Add(this.label3);
            this.tabLoginInfo.Controls.Add(this.txtPassword);
            this.tabLoginInfo.Controls.Add(this.pictureBox1);
            this.tabLoginInfo.Controls.Add(this.label1);
            this.tabLoginInfo.Controls.Add(this.txtUsername);
            this.tabLoginInfo.Controls.Add(this.pictureBox3);
            this.tabLoginInfo.Controls.Add(this.label2);
            this.tabLoginInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.tabLoginInfo.Location = new System.Drawing.Point(4, 29);
            this.tabLoginInfo.Name = "tabLoginInfo";
            this.tabLoginInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabLoginInfo.Size = new System.Drawing.Size(994, 518);
            this.tabLoginInfo.TabIndex = 1;
            this.tabLoginInfo.Text = "Login Info";
            // 
            // chkIsAcitve
            // 
            this.chkIsAcitve.AutoSize = true;
            this.chkIsAcitve.Checked = true;
            this.chkIsAcitve.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkIsAcitve.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.chkIsAcitve.Location = new System.Drawing.Point(285, 232);
            this.chkIsAcitve.Name = "chkIsAcitve";
            this.chkIsAcitve.Size = new System.Drawing.Size(95, 24);
            this.chkIsAcitve.TabIndex = 90;
            this.chkIsAcitve.Text = "Is Active";
            this.chkIsAcitve.UseVisualStyleBackColor = true;
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserID.Location = new System.Drawing.Point(281, 57);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(39, 20);
            this.lblUserID.TabIndex = 89;
            this.lblUserID.Text = "???";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::DVLD_Presentation.Properties.Resources.Number_32;
            this.pictureBox4.Location = new System.Drawing.Point(243, 51);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(32, 32);
            this.pictureBox4.TabIndex = 88;
            this.pictureBox4.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(134, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 20);
            this.label4.TabIndex = 87;
            this.label4.Text = "User ID:";
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtConfirmPassword.Location = new System.Drawing.Point(281, 182);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.PasswordChar = '●';
            this.txtConfirmPassword.Size = new System.Drawing.Size(177, 26);
            this.txtConfirmPassword.TabIndex = 80;
            this.txtConfirmPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtConfirmPassword_Validating);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::DVLD_Presentation.Properties.Resources.Number_32;
            this.pictureBox2.Location = new System.Drawing.Point(243, 180);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 32);
            this.pictureBox2.TabIndex = 86;
            this.pictureBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(45, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 20);
            this.label3.TabIndex = 85;
            this.label3.Text = "Confirm Password:";
            // 
            // txtPassword
            // 
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtPassword.Location = new System.Drawing.Point(281, 139);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '●';
            this.txtPassword.Size = new System.Drawing.Size(177, 26);
            this.txtPassword.TabIndex = 79;
            this.txtPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtPassword_Validating);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLD_Presentation.Properties.Resources.Number_32;
            this.pictureBox1.Location = new System.Drawing.Point(243, 137);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.TabIndex = 84;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(117, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 20);
            this.label1.TabIndex = 83;
            this.label1.Text = "Password:";
            // 
            // txtUsername
            // 
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtUsername.Location = new System.Drawing.Point(281, 96);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(177, 26);
            this.txtUsername.TabIndex = 78;
            this.txtUsername.Validating += new System.ComponentModel.CancelEventHandler(this.txtUsername_Validating);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::DVLD_Presentation.Properties.Resources.Person_32;
            this.pictureBox3.Location = new System.Drawing.Point(243, 94);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(32, 32);
            this.pictureBox3.TabIndex = 82;
            this.pictureBox3.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(117, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 81;
            this.label2.Text = "Username:";
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnSave.Image = global::DVLD_Presentation.Properties.Resources.Save_32;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(868, 672);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(142, 46);
            this.btnSave.TabIndex = 68;
            this.btnSave.Text = " Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // ctrlCloseButton1
            // 
            this.ctrlCloseButton1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ctrlCloseButton1.Image = ((System.Drawing.Image)(resources.GetObject("ctrlCloseButton1.Image")));
            this.ctrlCloseButton1.Location = new System.Drawing.Point(719, 672);
            this.ctrlCloseButton1.Name = "ctrlCloseButton1";
            this.ctrlCloseButton1.Size = new System.Drawing.Size(142, 46);
            this.ctrlCloseButton1.TabIndex = 69;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmAddUpdateUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.ctrlCloseButton1;
            this.ClientSize = new System.Drawing.Size(1016, 735);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.ctrlCloseButton1);
            this.Controls.Add(this.tcUserInfo);
            this.Controls.Add(this.ctrlTitle1);
            this.Name = "frmAddUpdateUser";
            this.Text = "Add / Edit User Info.";
            this.Activated += new System.EventHandler(this.frmAddUpdateUser_Activated);
            this.Load += new System.EventHandler(this.frmAddUpdateUser_Load);
            this.tcUserInfo.ResumeLayout(false);
            this.tabPersonalInfo.ResumeLayout(false);
            this.tabLoginInfo.ResumeLayout(false);
            this.tabLoginInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Global_Controls.ctrlTitle ctrlTitle1;
        private System.Windows.Forms.TabControl tcUserInfo;
        private System.Windows.Forms.TabPage tabPersonalInfo;
        private System.Windows.Forms.TabPage tabLoginInfo;
        private People.Controls.ctrlPersonCardWithFilter ctrlPersonCardWithFilter1;
        private System.Windows.Forms.Button btnSave;
        private ctrlCloseButton ctrlCloseButton1;
        private System.Windows.Forms.Button btnPersonalInfoNext;
        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkIsAcitve;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}