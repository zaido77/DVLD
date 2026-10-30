namespace DVLD_Presentation.Tests.Test_Appointments
{
    partial class frmScheduleTest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmScheduleTest));
            this.ctrlScheduleTest1 = new DVLD_Presentation.Tests.Test_Appointments.Controls.ctrlScheduleTest();
            this.ctrlCloseButton1 = new DVLD_Presentation.ctrlCloseButton();
            this.SuspendLayout();
            // 
            // ctrlScheduleTest1
            // 
            this.ctrlScheduleTest1.BackColor = System.Drawing.Color.White;
            this.ctrlScheduleTest1.Location = new System.Drawing.Point(12, 12);
            this.ctrlScheduleTest1.Name = "ctrlScheduleTest1";
            this.ctrlScheduleTest1.Size = new System.Drawing.Size(615, 764);
            this.ctrlScheduleTest1.TabIndex = 0;
            // 
            // ctrlCloseButton1
            // 
            this.ctrlCloseButton1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ctrlCloseButton1.Image = ((System.Drawing.Image)(resources.GetObject("ctrlCloseButton1.Image")));
            this.ctrlCloseButton1.Location = new System.Drawing.Point(247, 782);
            this.ctrlCloseButton1.Name = "ctrlCloseButton1";
            this.ctrlCloseButton1.Size = new System.Drawing.Size(143, 44);
            this.ctrlCloseButton1.TabIndex = 1;
            this.ctrlCloseButton1.Text = "ctrlCloseButton1";
            this.ctrlCloseButton1.UseVisualStyleBackColor = true;
            // 
            // frmScheduleTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.ctrlCloseButton1;
            this.ClientSize = new System.Drawing.Size(644, 837);
            this.Controls.Add(this.ctrlCloseButton1);
            this.Controls.Add(this.ctrlScheduleTest1);
            this.Name = "frmScheduleTest";
            this.Text = "Schedule Test";
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.ctrlScheduleTest ctrlScheduleTest1;
        private ctrlCloseButton ctrlCloseButton1;
    }
}