namespace DVLD_Presentation.Licenses.Controls
{
    partial class ctrlLocalLicenseCardWithFilter
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ctrlLocalLicenseCard1 = new DVLD_Presentation.Licenses.Local_Licenses.ctrlLocalLicenseCard();
            this.gbFilter = new System.Windows.Forms.GroupBox();
            this.btnSearchLicense = new System.Windows.Forms.Button();
            this.txtLicenseID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // ctrlLocalLicenseCard1
            // 
            this.ctrlLocalLicenseCard1.BackColor = System.Drawing.Color.White;
            this.ctrlLocalLicenseCard1.Location = new System.Drawing.Point(-1, 113);
            this.ctrlLocalLicenseCard1.Name = "ctrlLocalLicenseCard1";
            this.ctrlLocalLicenseCard1.Size = new System.Drawing.Size(971, 382);
            this.ctrlLocalLicenseCard1.TabIndex = 0;
            // 
            // gbFilter
            // 
            this.gbFilter.Controls.Add(this.btnSearchLicense);
            this.gbFilter.Controls.Add(this.txtLicenseID);
            this.gbFilter.Controls.Add(this.label1);
            this.gbFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.gbFilter.Location = new System.Drawing.Point(9, 5);
            this.gbFilter.Name = "gbFilter";
            this.gbFilter.Size = new System.Drawing.Size(657, 108);
            this.gbFilter.TabIndex = 1;
            this.gbFilter.TabStop = false;
            this.gbFilter.Text = "Filter";
            // 
            // btnSearchLicense
            // 
            this.btnSearchLicense.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchLicense.Image = global::DVLD_Presentation.Properties.Resources.License_View_32;
            this.btnSearchLicense.Location = new System.Drawing.Point(560, 25);
            this.btnSearchLicense.Name = "btnSearchLicense";
            this.btnSearchLicense.Size = new System.Drawing.Size(81, 63);
            this.btnSearchLicense.TabIndex = 69;
            this.btnSearchLicense.UseVisualStyleBackColor = true;
            this.btnSearchLicense.Click += new System.EventHandler(this.btnSearchLicense_Click);
            // 
            // txtFilterValue
            // 
            this.txtLicenseID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLicenseID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtLicenseID.Location = new System.Drawing.Point(168, 41);
            this.txtLicenseID.Name = "txtFilterValue";
            this.txtLicenseID.Size = new System.Drawing.Size(359, 30);
            this.txtLicenseID.TabIndex = 68;
            this.txtLicenseID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFilterValue_KeyPress);
            this.txtLicenseID.Validating += new System.ComponentModel.CancelEventHandler(this.txtLicenseID_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 20);
            this.label1.TabIndex = 66;
            this.label1.Text = "License ID:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ctrlLocalLicenseCardWithFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.gbFilter);
            this.Controls.Add(this.ctrlLocalLicenseCard1);
            this.Name = "ctrlLocalLicenseCardWithFilter";
            this.Size = new System.Drawing.Size(970, 491);
            this.gbFilter.ResumeLayout(false);
            this.gbFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Local_Licenses.ctrlLocalLicenseCard ctrlLocalLicenseCard1;
        private System.Windows.Forms.GroupBox gbFilter;
        private System.Windows.Forms.Button btnSearchLicense;
        private System.Windows.Forms.TextBox txtLicenseID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
