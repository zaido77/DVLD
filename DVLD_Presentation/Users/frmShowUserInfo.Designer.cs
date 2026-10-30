namespace DVLD_Presentation.Users
{
    partial class frmShowUserInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmShowUserInfo));
            this.ctrlUserCard1 = new DVLD_Presentation.Users.ctrlUserCard();
            this.ctrlCloseButton1 = new DVLD_Presentation.ctrlCloseButton();
            this.SuspendLayout();
            // 
            // ctrlUserCard1
            // 
            this.ctrlUserCard1.BackColor = System.Drawing.Color.White;
            this.ctrlUserCard1.Location = new System.Drawing.Point(17, 39);
            this.ctrlUserCard1.Name = "ctrlUserCard1";
            this.ctrlUserCard1.Size = new System.Drawing.Size(969, 444);
            this.ctrlUserCard1.TabIndex = 2;
            // 
            // ctrlCloseButton1
            // 
            this.ctrlCloseButton1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ctrlCloseButton1.Image = ((System.Drawing.Image)(resources.GetObject("ctrlCloseButton1.Image")));
            this.ctrlCloseButton1.Location = new System.Drawing.Point(818, 477);
            this.ctrlCloseButton1.Name = "ctrlCloseButton1";
            this.ctrlCloseButton1.Size = new System.Drawing.Size(160, 45);
            this.ctrlCloseButton1.TabIndex = 0;
            this.ctrlCloseButton1.Text = "ctrlCloseButton1";
            this.ctrlCloseButton1.UseVisualStyleBackColor = true;
            // 
            // frmShowUserInfo
            // 
            this.AcceptButton = this.ctrlCloseButton1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.ctrlCloseButton1;
            this.ClientSize = new System.Drawing.Size(1002, 539);
            this.Controls.Add(this.ctrlCloseButton1);
            this.Controls.Add(this.ctrlUserCard1);
            this.Name = "frmShowUserInfo";
            this.Text = "User Details";
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlUserCard ctrlUserCard1;
        private ctrlCloseButton ctrlCloseButton1;
    }
}