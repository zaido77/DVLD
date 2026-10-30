namespace DVLD_Presentation.People
{
    partial class frmSendEmail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSendEmail));
            this.txtBody = new System.Windows.Forms.TextBox();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnSendEmail = new System.Windows.Forms.Button();
            this.ctrlCloseButton1 = new DVLD_Presentation.ctrlCloseButton();
            this.ctrlTitle1 = new DVLD_Presentation.Global_Controls.ctrlTitle();
            this.ctrlPersonCard1 = new DVLD_Presentation.People.ctrlPersonCard();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBody
            // 
            this.txtBody.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBody.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtBody.Location = new System.Drawing.Point(135, 486);
            this.txtBody.Multiline = true;
            this.txtBody.Name = "txtBody";
            this.txtBody.Size = new System.Drawing.Size(831, 165);
            this.txtBody.TabIndex = 2;
            // 
            // txtSubject
            // 
            this.txtSubject.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtSubject.Location = new System.Drawing.Point(135, 444);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(831, 26);
            this.txtSubject.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 492);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 20);
            this.label6.TabIndex = 32;
            this.label6.Text = "Body:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 446);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 31;
            this.label2.Text = "Subject:";
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::DVLD_Presentation.Properties.Resources.Email_32;
            this.pictureBox6.Location = new System.Drawing.Point(97, 486);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(32, 32);
            this.pictureBox6.TabIndex = 34;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::DVLD_Presentation.Properties.Resources.Number_32;
            this.pictureBox3.Location = new System.Drawing.Point(97, 438);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(32, 32);
            this.pictureBox3.TabIndex = 33;
            this.pictureBox3.TabStop = false;
            // 
            // btnSendEmail
            // 
            this.btnSendEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSendEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnSendEmail.Image = global::DVLD_Presentation.Properties.Resources.send_email_32;
            this.btnSendEmail.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSendEmail.Location = new System.Drawing.Point(785, 686);
            this.btnSendEmail.Name = "btnSendEmail";
            this.btnSendEmail.Size = new System.Drawing.Size(178, 57);
            this.btnSendEmail.TabIndex = 3;
            this.btnSendEmail.Text = "    Send Email";
            this.btnSendEmail.UseVisualStyleBackColor = true;
            this.btnSendEmail.Click += new System.EventHandler(this.btnSendEmail_Click);
            // 
            // ctrlCloseButton1
            // 
            this.ctrlCloseButton1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ctrlCloseButton1.Image = ((System.Drawing.Image)(resources.GetObject("ctrlCloseButton1.Image")));
            this.ctrlCloseButton1.Location = new System.Drawing.Point(644, 686);
            this.ctrlCloseButton1.Name = "ctrlCloseButton1";
            this.ctrlCloseButton1.Size = new System.Drawing.Size(135, 57);
            this.ctrlCloseButton1.TabIndex = 4;
            // 
            // ctrlTitle1
            // 
            this.ctrlTitle1.Location = new System.Drawing.Point(251, 28);
            this.ctrlTitle1.Name = "ctrlTitle1";
            this.ctrlTitle1.Size = new System.Drawing.Size(473, 54);
            this.ctrlTitle1.TabIndex = 39;
            this.ctrlTitle1.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.ctrlTitle1.TitleText = "Send Email To";
            // 
            // ctrlPersonCard1
            // 
            this.ctrlPersonCard1.Location = new System.Drawing.Point(6, 84);
            this.ctrlPersonCard1.Name = "ctrlPersonCard1";
            this.ctrlPersonCard1.Size = new System.Drawing.Size(971, 340);
            this.ctrlPersonCard1.TabIndex = 40;
            // 
            // frmSendEmail
            // 
            this.AcceptButton = this.btnSendEmail;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.ctrlCloseButton1;
            this.ClientSize = new System.Drawing.Size(981, 756);
            this.Controls.Add(this.ctrlPersonCard1);
            this.Controls.Add(this.ctrlTitle1);
            this.Controls.Add(this.btnSendEmail);
            this.Controls.Add(this.ctrlCloseButton1);
            this.Controls.Add(this.txtBody);
            this.Controls.Add(this.txtSubject);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Name = "frmSendEmail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Send Email";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtBody;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private ctrlCloseButton ctrlCloseButton1;
        private System.Windows.Forms.Button btnSendEmail;
        private Global_Controls.ctrlTitle ctrlTitle1;
        private ctrlPersonCard ctrlPersonCard1;
    }
}