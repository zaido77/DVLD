namespace DVLD_Presentation.Tests.Test_Appointments
{
    partial class frmTakeTest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTakeTest));
            this.ctrlTestInfo1 = new DVLD_Presentation.Tests.Controls.ctrlTestInfo();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rbPass = new System.Windows.Forms.RadioButton();
            this.rbFail = new System.Windows.Forms.RadioButton();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.ctrlCloseButton1 = new DVLD_Presentation.ctrlCloseButton();
            this.lblLockMessage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // ctrlTestInfo1
            // 
            this.ctrlTestInfo1.BackColor = System.Drawing.Color.White;
            this.ctrlTestInfo1.Location = new System.Drawing.Point(11, 16);
            this.ctrlTestInfo1.Name = "ctrlTestInfo1";
            this.ctrlTestInfo1.Size = new System.Drawing.Size(615, 583);
            this.ctrlTestInfo1.TabIndex = 0;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::DVLD_Presentation.Properties.Resources.Number_32;
            this.pictureBox7.Location = new System.Drawing.Point(150, 598);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(32, 32);
            this.pictureBox7.TabIndex = 100;
            this.pictureBox7.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(67, 602);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 97;
            this.label1.Text = "Result:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::DVLD_Presentation.Properties.Resources.Notes_32;
            this.pictureBox2.Location = new System.Drawing.Point(150, 638);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 32);
            this.pictureBox2.TabIndex = 96;
            this.pictureBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(72, 642);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 95;
            this.label3.Text = "Notes:";
            // 
            // rbPass
            // 
            this.rbPass.AutoSize = true;
            this.rbPass.Checked = true;
            this.rbPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rbPass.Location = new System.Drawing.Point(205, 602);
            this.rbPass.Name = "rbPass";
            this.rbPass.Size = new System.Drawing.Size(68, 24);
            this.rbPass.TabIndex = 101;
            this.rbPass.TabStop = true;
            this.rbPass.Text = "Pass";
            this.rbPass.UseVisualStyleBackColor = true;
            // 
            // rbFail
            // 
            this.rbFail.AutoSize = true;
            this.rbFail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rbFail.Location = new System.Drawing.Point(282, 602);
            this.rbFail.Name = "rbFail";
            this.rbFail.Size = new System.Drawing.Size(57, 24);
            this.rbFail.TabIndex = 102;
            this.rbFail.Text = "Fail";
            this.rbFail.UseVisualStyleBackColor = true;
            // 
            // txtNotes
            // 
            this.txtNotes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtNotes.Location = new System.Drawing.Point(205, 638);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(411, 109);
            this.txtNotes.TabIndex = 103;
            // 
            // btnSave
            // 
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnSave.Image = global::DVLD_Presentation.Properties.Resources.Save_32;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(463, 761);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(153, 50);
            this.btnSave.TabIndex = 104;
            this.btnSave.Text = " Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // ctrlCloseButton1
            // 
            this.ctrlCloseButton1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ctrlCloseButton1.Image = ((System.Drawing.Image)(resources.GetObject("ctrlCloseButton1.Image")));
            this.ctrlCloseButton1.Location = new System.Drawing.Point(295, 761);
            this.ctrlCloseButton1.Name = "ctrlCloseButton1";
            this.ctrlCloseButton1.Size = new System.Drawing.Size(153, 50);
            this.ctrlCloseButton1.TabIndex = 105;
            // 
            // lblLockMessage
            // 
            this.lblLockMessage.AutoSize = true;
            this.lblLockMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLockMessage.ForeColor = System.Drawing.Color.Red;
            this.lblLockMessage.Location = new System.Drawing.Point(353, 604);
            this.lblLockMessage.Name = "lblLockMessage";
            this.lblLockMessage.Size = new System.Drawing.Size(264, 20);
            this.lblLockMessage.TabIndex = 106;
            this.lblLockMessage.Text = "You cannot change the results";
            this.lblLockMessage.Visible = false;
            // 
            // frmTakeTest
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.ctrlCloseButton1;
            this.ClientSize = new System.Drawing.Size(639, 823);
            this.Controls.Add(this.lblLockMessage);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.ctrlCloseButton1);
            this.Controls.Add(this.txtNotes);
            this.Controls.Add(this.rbFail);
            this.Controls.Add(this.rbPass);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ctrlTestInfo1);
            this.Name = "frmTakeTest";
            this.Text = "Take Test";
            this.Load += new System.EventHandler(this.frmTakeTest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Tests.Controls.ctrlTestInfo ctrlTestInfo1;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbPass;
        private System.Windows.Forms.RadioButton rbFail;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Button btnSave;
        private ctrlCloseButton ctrlCloseButton1;
        private System.Windows.Forms.Label lblLockMessage;
    }
}