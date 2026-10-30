namespace DVLD_Presentation.Applications.International_License
{
    partial class frmListInternationalLicenseApplications
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListInternationalLicenseApplications));
            this.btnNewIntLicenseApplication = new System.Windows.Forms.Button();
            this.ctrlCloseButton1 = new DVLD_Presentation.ctrlCloseButton();
            this.pbHeader = new System.Windows.Forms.PictureBox();
            this.showPersonLicenseHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showPersonDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsInternationalLicenseApplications = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showLicenseDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dlInternationalLicenseApplications = new DVLD_Presentation.Global_Controls.ctrlDataListWithFilter();
            this.ctrlTitle1 = new DVLD_Presentation.Global_Controls.ctrlTitle();
            this.pbSubHeader = new System.Windows.Forms.PictureBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            ((System.ComponentModel.ISupportInitialize)(this.pbHeader)).BeginInit();
            this.cmsInternationalLicenseApplications.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSubHeader)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNewIntLicenseApplication
            // 
            this.btnNewIntLicenseApplication.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewIntLicenseApplication.Image = global::DVLD_Presentation.Properties.Resources.New_Application_64;
            this.btnNewIntLicenseApplication.Location = new System.Drawing.Point(1109, 228);
            this.btnNewIntLicenseApplication.Name = "btnNewIntLicenseApplication";
            this.btnNewIntLicenseApplication.Size = new System.Drawing.Size(99, 82);
            this.btnNewIntLicenseApplication.TabIndex = 11;
            this.btnNewIntLicenseApplication.UseVisualStyleBackColor = true;
            this.btnNewIntLicenseApplication.Click += new System.EventHandler(this.btnNewIntLicenseApplication_Click);
            // 
            // ctrlCloseButton1
            // 
            this.ctrlCloseButton1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ctrlCloseButton1.Image = ((System.Drawing.Image)(resources.GetObject("ctrlCloseButton1.Image")));
            this.ctrlCloseButton1.Location = new System.Drawing.Point(1040, 695);
            this.ctrlCloseButton1.Name = "ctrlCloseButton1";
            this.ctrlCloseButton1.Size = new System.Drawing.Size(168, 42);
            this.ctrlCloseButton1.TabIndex = 10;
            this.ctrlCloseButton1.Text = "ctrlCloseButton1";
            this.ctrlCloseButton1.UseVisualStyleBackColor = true;
            // 
            // pbHeader
            // 
            this.pbHeader.Image = global::DVLD_Presentation.Properties.Resources.Applications;
            this.pbHeader.Location = new System.Drawing.Point(516, -5);
            this.pbHeader.Name = "pbHeader";
            this.pbHeader.Size = new System.Drawing.Size(194, 197);
            this.pbHeader.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbHeader.TabIndex = 6;
            this.pbHeader.TabStop = false;
            // 
            // showPersonLicenseHistoryToolStripMenuItem
            // 
            this.showPersonLicenseHistoryToolStripMenuItem.Image = global::DVLD_Presentation.Properties.Resources.PersonLicenseHistory_32;
            this.showPersonLicenseHistoryToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.showPersonLicenseHistoryToolStripMenuItem.Name = "showPersonLicenseHistoryToolStripMenuItem";
            this.showPersonLicenseHistoryToolStripMenuItem.Size = new System.Drawing.Size(280, 38);
            this.showPersonLicenseHistoryToolStripMenuItem.Text = "Show Person License &History";
            this.showPersonLicenseHistoryToolStripMenuItem.Click += new System.EventHandler(this.showPersonLicenseHistoryToolStripMenuItem_Click);
            // 
            // showPersonDetailsToolStripMenuItem
            // 
            this.showPersonDetailsToolStripMenuItem.Image = global::DVLD_Presentation.Properties.Resources.PersonDetails_32;
            this.showPersonDetailsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.showPersonDetailsToolStripMenuItem.Name = "showPersonDetailsToolStripMenuItem";
            this.showPersonDetailsToolStripMenuItem.Size = new System.Drawing.Size(280, 38);
            this.showPersonDetailsToolStripMenuItem.Text = "&Show Person Details";
            this.showPersonDetailsToolStripMenuItem.Click += new System.EventHandler(this.showPersonDetailsToolStripMenuItem_Click);
            // 
            // cmsInternationalLicenseApplications
            // 
            this.cmsInternationalLicenseApplications.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsInternationalLicenseApplications.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showLicenseDetailsToolStripMenuItem,
            this.toolStripSeparator1,
            this.showPersonDetailsToolStripMenuItem,
            this.toolStripSeparator2,
            this.showPersonLicenseHistoryToolStripMenuItem});
            this.cmsInternationalLicenseApplications.Name = "contextMenuStrip1";
            this.cmsInternationalLicenseApplications.Size = new System.Drawing.Size(281, 130);
            this.cmsInternationalLicenseApplications.Opening += new System.ComponentModel.CancelEventHandler(this.cmsInternationalLicenseApplications_Opening);
            // 
            // showLicenseDetailsToolStripMenuItem
            // 
            this.showLicenseDetailsToolStripMenuItem.Image = global::DVLD_Presentation.Properties.Resources.License_View_32;
            this.showLicenseDetailsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.showLicenseDetailsToolStripMenuItem.Name = "showLicenseDetailsToolStripMenuItem";
            this.showLicenseDetailsToolStripMenuItem.Size = new System.Drawing.Size(280, 38);
            this.showLicenseDetailsToolStripMenuItem.Text = "Show &License Details";
            this.showLicenseDetailsToolStripMenuItem.Click += new System.EventHandler(this.showLicenseDetailsToolStripMenuItem_Click);
            // 
            // dlInternationalLicenseApplications
            // 
            this.dlInternationalLicenseApplications.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.None;
            this.dlInternationalLicenseApplications.BackColor = System.Drawing.Color.White;
            this.dlInternationalLicenseApplications.ContextMenuStrip = this.cmsInternationalLicenseApplications;
            this.dlInternationalLicenseApplications.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dlInternationalLicenseApplications.Location = new System.Drawing.Point(14, 278);
            this.dlInternationalLicenseApplications.Margin = new System.Windows.Forms.Padding(5);
            this.dlInternationalLicenseApplications.Name = "dlInternationalLicenseApplications";
            this.dlInternationalLicenseApplications.Size = new System.Drawing.Size(1199, 440);
            this.dlInternationalLicenseApplications.TabIndex = 9;
            this.dlInternationalLicenseApplications.RowDoubleClick += new System.EventHandler(this.dlInternationalLicenseApplications_RowDoubleClick);
            // 
            // ctrlTitle1
            // 
            this.ctrlTitle1.Location = new System.Drawing.Point(80, 198);
            this.ctrlTitle1.Name = "ctrlTitle1";
            this.ctrlTitle1.Size = new System.Drawing.Size(1067, 54);
            this.ctrlTitle1.TabIndex = 8;
            this.ctrlTitle1.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.ctrlTitle1.TitleText = "International License Applications";
            // 
            // pbSubHeader
            // 
            this.pbSubHeader.Image = global::DVLD_Presentation.Properties.Resources.International_32;
            this.pbSubHeader.Location = new System.Drawing.Point(686, 60);
            this.pbSubHeader.Name = "pbSubHeader";
            this.pbSubHeader.Size = new System.Drawing.Size(58, 61);
            this.pbSubHeader.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSubHeader.TabIndex = 7;
            this.pbSubHeader.TabStop = false;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(277, 6);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(277, 6);
            // 
            // frmListInternationalLicenseApplications
            // 
            this.AcceptButton = this.btnNewIntLicenseApplication;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.ctrlCloseButton1;
            this.ClientSize = new System.Drawing.Size(1220, 744);
            this.Controls.Add(this.btnNewIntLicenseApplication);
            this.Controls.Add(this.ctrlCloseButton1);
            this.Controls.Add(this.dlInternationalLicenseApplications);
            this.Controls.Add(this.ctrlTitle1);
            this.Controls.Add(this.pbSubHeader);
            this.Controls.Add(this.pbHeader);
            this.Name = "frmListInternationalLicenseApplications";
            this.Text = "List International License Applications";
            this.Load += new System.EventHandler(this.frmListInternationalLicenseApplications_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbHeader)).EndInit();
            this.cmsInternationalLicenseApplications.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbSubHeader)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNewIntLicenseApplication;
        private ctrlCloseButton ctrlCloseButton1;
        private System.Windows.Forms.PictureBox pbHeader;
        private System.Windows.Forms.ToolStripMenuItem showPersonLicenseHistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showPersonDetailsToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip cmsInternationalLicenseApplications;
        private Global_Controls.ctrlDataListWithFilter dlInternationalLicenseApplications;
        private Global_Controls.ctrlTitle ctrlTitle1;
        private System.Windows.Forms.PictureBox pbSubHeader;
        private System.Windows.Forms.ToolStripMenuItem showLicenseDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    }
}