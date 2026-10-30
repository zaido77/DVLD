namespace DVLD_Presentation.People
{
    partial class frmFindPerson
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFindPerson));
            this.ctrlPersonCardWithFilter1 = new DVLD_Presentation.People.Controls.ctrlPersonCardWithFilter();
            this.ctrlCloseButton1 = new DVLD_Presentation.ctrlCloseButton();
            this.ctrlTitle1 = new DVLD_Presentation.Global_Controls.ctrlTitle();
            this.SuspendLayout();
            // 
            // ctrlPersonCardWithFilter1
            // 
            this.ctrlPersonCardWithFilter1.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ctrlPersonCardWithFilter1.BackColor = System.Drawing.Color.White;
            this.ctrlPersonCardWithFilter1.FilterEnabled = true;
            this.ctrlPersonCardWithFilter1.Location = new System.Drawing.Point(12, 91);
            this.ctrlPersonCardWithFilter1.Name = "ctrlPersonCardWithFilter1";
            this.ctrlPersonCardWithFilter1.ShowAddPerson = true;
            this.ctrlPersonCardWithFilter1.Size = new System.Drawing.Size(973, 440);
            this.ctrlPersonCardWithFilter1.TabIndex = 0;
            // 
            // ctrlCloseButton1
            // 
            this.ctrlCloseButton1.Image = ((System.Drawing.Image)(resources.GetObject("ctrlCloseButton1.Image")));
            this.ctrlCloseButton1.Location = new System.Drawing.Point(828, 537);
            this.ctrlCloseButton1.Name = "ctrlCloseButton1";
            this.ctrlCloseButton1.Size = new System.Drawing.Size(146, 43);
            this.ctrlCloseButton1.TabIndex = 1;
            this.ctrlCloseButton1.Text = "ctrlCloseButton1";
            this.ctrlCloseButton1.UseVisualStyleBackColor = true;
            // 
            // ctrlTitle1
            // 
            this.ctrlTitle1.Location = new System.Drawing.Point(215, 31);
            this.ctrlTitle1.Name = "ctrlTitle1";
            this.ctrlTitle1.Size = new System.Drawing.Size(566, 54);
            this.ctrlTitle1.TabIndex = 2;
            this.ctrlTitle1.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.ctrlTitle1.TitleText = "Find Person";
            // 
            // frmFindPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 600);
            this.Controls.Add(this.ctrlTitle1);
            this.Controls.Add(this.ctrlCloseButton1);
            this.Controls.Add(this.ctrlPersonCardWithFilter1);
            this.Name = "frmFindPerson";
            this.Text = "Find Person";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmFindPerson_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.ctrlPersonCardWithFilter ctrlPersonCardWithFilter1;
        private ctrlCloseButton ctrlCloseButton1;
        private Global_Controls.ctrlTitle ctrlTitle1;
    }
}