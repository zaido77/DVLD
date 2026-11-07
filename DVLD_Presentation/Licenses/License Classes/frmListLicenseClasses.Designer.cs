namespace DVLD_Presentation.Licenses.License_Classes
{
    partial class frmListLicenseClasses
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListLicenseClasses));
            this.dlLicenseClasses = new DVLD_Presentation.Global_Controls.ctrlDataList();
            this.cmsLicenseClasses = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.editLicenseClassToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ctrlTitle1 = new DVLD_Presentation.Global_Controls.ctrlTitle();
            this.ctrlCloseButton1 = new DVLD_Presentation.ctrlCloseButton();
            this.pbHeader = new System.Windows.Forms.PictureBox();
            this.cmsLicenseClasses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbHeader)).BeginInit();
            this.SuspendLayout();
            // 
            // dlLicenseClasses
            // 
            this.dlLicenseClasses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.None;
            this.dlLicenseClasses.BackColor = System.Drawing.Color.White;
            this.dlLicenseClasses.ContextMenuStrip = this.cmsLicenseClasses;
            this.dlLicenseClasses.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dlLicenseClasses.Location = new System.Drawing.Point(13, 313);
            this.dlLicenseClasses.Margin = new System.Windows.Forms.Padding(4);
            this.dlLicenseClasses.Name = "dlLicenseClasses";
            this.dlLicenseClasses.Size = new System.Drawing.Size(1292, 429);
            this.dlLicenseClasses.TabIndex = 10;
            // 
            // cmsLicenseClasses
            // 
            this.cmsLicenseClasses.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmsLicenseClasses.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsLicenseClasses.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.editLicenseClassToolStripMenuItem,
            this.toolStripSeparator2});
            this.cmsLicenseClasses.Name = "cmsApplicationTypes";
            this.cmsLicenseClasses.Size = new System.Drawing.Size(229, 54);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(225, 6);
            // 
            // editLicenseClassToolStripMenuItem
            // 
            this.editLicenseClassToolStripMenuItem.Image = global::DVLD_Presentation.Properties.Resources.edit_32;
            this.editLicenseClassToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.editLicenseClassToolStripMenuItem.Name = "editLicenseClassToolStripMenuItem";
            this.editLicenseClassToolStripMenuItem.Size = new System.Drawing.Size(228, 38);
            this.editLicenseClassToolStripMenuItem.Text = "&Edit License Class";
            this.editLicenseClassToolStripMenuItem.Click += new System.EventHandler(this.editLicenseClassToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(225, 6);
            // 
            // ctrlTitle1
            // 
            this.ctrlTitle1.Location = new System.Drawing.Point(293, 225);
            this.ctrlTitle1.Name = "ctrlTitle1";
            this.ctrlTitle1.Size = new System.Drawing.Size(728, 54);
            this.ctrlTitle1.TabIndex = 12;
            this.ctrlTitle1.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.ctrlTitle1.TitleText = "Manage License Classes";
            // 
            // ctrlCloseButton1
            // 
            this.ctrlCloseButton1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ctrlCloseButton1.Image = ((System.Drawing.Image)(resources.GetObject("ctrlCloseButton1.Image")));
            this.ctrlCloseButton1.Location = new System.Drawing.Point(1113, 717);
            this.ctrlCloseButton1.Name = "ctrlCloseButton1";
            this.ctrlCloseButton1.Size = new System.Drawing.Size(187, 41);
            this.ctrlCloseButton1.TabIndex = 13;
            this.ctrlCloseButton1.Text = "ctrlCloseButton1";
            this.ctrlCloseButton1.UseVisualStyleBackColor = true;
            // 
            // pbHeader
            // 
            this.pbHeader.Image = global::DVLD_Presentation.Properties.Resources.License_Class_512;
            this.pbHeader.Location = new System.Drawing.Point(515, 13);
            this.pbHeader.Name = "pbHeader";
            this.pbHeader.Size = new System.Drawing.Size(288, 228);
            this.pbHeader.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbHeader.TabIndex = 11;
            this.pbHeader.TabStop = false;
            // 
            // frmListLicenseClasses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.ctrlCloseButton1;
            this.ClientSize = new System.Drawing.Size(1310, 770);
            this.Controls.Add(this.ctrlCloseButton1);
            this.Controls.Add(this.dlLicenseClasses);
            this.Controls.Add(this.ctrlTitle1);
            this.Controls.Add(this.pbHeader);
            this.Name = "frmListLicenseClasses";
            this.Text = "List License Classes";
            this.Load += new System.EventHandler(this.frmListLicenseClasses_Load);
            this.cmsLicenseClasses.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbHeader)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Global_Controls.ctrlDataList dlLicenseClasses;
        private System.Windows.Forms.ContextMenuStrip cmsLicenseClasses;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem editLicenseClassToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private ctrlCloseButton ctrlCloseButton1;
        private Global_Controls.ctrlTitle ctrlTitle1;
        private System.Windows.Forms.PictureBox pbHeader;
    }
}