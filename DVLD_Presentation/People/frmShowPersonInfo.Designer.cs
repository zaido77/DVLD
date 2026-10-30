namespace DVLD_Presentation.People
{
    partial class frmShowPersonInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmShowPersonInfo));
            this.ctrlTitle1 = new DVLD_Presentation.Global_Controls.ctrlTitle();
            this.ctrlCloseButton1 = new DVLD_Presentation.ctrlCloseButton();
            this.ctrlPersonCard1 = new DVLD_Presentation.People.ctrlPersonCard();
            this.SuspendLayout();
            // 
            // ctrlTitle1
            // 
            this.ctrlTitle1.Location = new System.Drawing.Point(280, 35);
            this.ctrlTitle1.Name = "ctrlTitle1";
            this.ctrlTitle1.Size = new System.Drawing.Size(415, 54);
            this.ctrlTitle1.TabIndex = 5;
            this.ctrlTitle1.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.ctrlTitle1.TitleText = "Person Details";
            // 
            // ctrlCloseButton1
            // 
            this.ctrlCloseButton1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ctrlCloseButton1.Image = ((System.Drawing.Image)(resources.GetObject("ctrlCloseButton1.Image")));
            this.ctrlCloseButton1.Location = new System.Drawing.Point(833, 445);
            this.ctrlCloseButton1.Name = "ctrlCloseButton1";
            this.ctrlCloseButton1.Size = new System.Drawing.Size(135, 45);
            this.ctrlCloseButton1.TabIndex = 1;
            this.ctrlCloseButton1.Text = "ctrlCloseButton1";
            this.ctrlCloseButton1.UseVisualStyleBackColor = true;
            // 
            // ctrlPersonCard1
            // 
            this.ctrlPersonCard1.Location = new System.Drawing.Point(8, 96);
            this.ctrlPersonCard1.Name = "ctrlPersonCard1";
            this.ctrlPersonCard1.Size = new System.Drawing.Size(971, 338);
            this.ctrlPersonCard1.TabIndex = 6;
            // 
            // frmShowPersonInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.ctrlCloseButton1;
            this.ClientSize = new System.Drawing.Size(985, 502);
            this.Controls.Add(this.ctrlPersonCard1);
            this.Controls.Add(this.ctrlCloseButton1);
            this.Controls.Add(this.ctrlTitle1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmShowPersonInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Person Details";
            this.ResumeLayout(false);

        }

        #endregion
        private Global_Controls.ctrlTitle ctrlTitle1;
        private ctrlCloseButton ctrlCloseButton1;
        private ctrlPersonCard ctrlPersonCard1;
    }
}