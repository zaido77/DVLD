namespace DVLD_Presentation.Applications.Local_License_Applications
{
    partial class frmListLocalDrivingLicenseApplications
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListLocalDrivingLicenseApplications));
            this.ctrlTitle1 = new DVLD_Presentation.Global_Controls.ctrlTitle();
            this.dlLocalDrivingLicenseApplications = new DVLD_Presentation.Global_Controls.ctrlDataListWithFilter();
            this.cmsLocalDrivingLicenseApplications = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showApplicationDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.editApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.cancelApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.scheduleTestsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scheduleVisionTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scheduleWrittenTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scheduleStreetTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.issueDrivingLicenseFirstTimeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.showLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.showPersonLicenseHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAddLocalDLApplication = new System.Windows.Forms.Button();
            this.ctrlCloseButton1 = new DVLD_Presentation.ctrlCloseButton();
            this.pbSubHeader = new System.Windows.Forms.PictureBox();
            this.pbHeader = new System.Windows.Forms.PictureBox();
            this.cmsLocalDrivingLicenseApplications.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSubHeader)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHeader)).BeginInit();
            this.SuspendLayout();
            // 
            // ctrlTitle1
            // 
            this.ctrlTitle1.Location = new System.Drawing.Point(220, 215);
            this.ctrlTitle1.Name = "ctrlTitle1";
            this.ctrlTitle1.Size = new System.Drawing.Size(1067, 54);
            this.ctrlTitle1.TabIndex = 2;
            this.ctrlTitle1.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.ctrlTitle1.TitleText = "Local Driving License Applications";
            // 
            // dlLocalDrivingLicenseApplications
            // 
            this.dlLocalDrivingLicenseApplications.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.None;
            this.dlLocalDrivingLicenseApplications.BackColor = System.Drawing.Color.White;
            this.dlLocalDrivingLicenseApplications.ContextMenuStrip = this.cmsLocalDrivingLicenseApplications;
            this.dlLocalDrivingLicenseApplications.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dlLocalDrivingLicenseApplications.Location = new System.Drawing.Point(14, 284);
            this.dlLocalDrivingLicenseApplications.Margin = new System.Windows.Forms.Padding(5);
            this.dlLocalDrivingLicenseApplications.Name = "dlLocalDrivingLicenseApplications";
            this.dlLocalDrivingLicenseApplications.Size = new System.Drawing.Size(1476, 427);
            this.dlLocalDrivingLicenseApplications.TabIndex = 3;
            this.dlLocalDrivingLicenseApplications.RowDoubleClick += new System.EventHandler(this.dlLocalDrivingLicenseApplications_RowDoubleClick);
            // 
            // cmsLocalDrivingLicenseApplications
            // 
            this.cmsLocalDrivingLicenseApplications.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsLocalDrivingLicenseApplications.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showApplicationDetailsToolStripMenuItem,
            this.toolStripSeparator1,
            this.editApplicationToolStripMenuItem,
            this.deleteApplicationToolStripMenuItem,
            this.toolStripSeparator2,
            this.cancelApplicationToolStripMenuItem,
            this.toolStripSeparator3,
            this.scheduleTestsToolStripMenuItem,
            this.toolStripSeparator4,
            this.issueDrivingLicenseFirstTimeToolStripMenuItem,
            this.toolStripSeparator5,
            this.showLicenseToolStripMenuItem,
            this.toolStripSeparator6,
            this.showPersonLicenseHistoryToolStripMenuItem});
            this.cmsLocalDrivingLicenseApplications.Name = "contextMenuStrip1";
            this.cmsLocalDrivingLicenseApplications.Size = new System.Drawing.Size(309, 372);
            this.cmsLocalDrivingLicenseApplications.Opening += new System.ComponentModel.CancelEventHandler(this.cmsLocalDrivingLicenseApplications_Opening);
            // 
            // showApplicationDetailsToolStripMenuItem
            // 
            this.showApplicationDetailsToolStripMenuItem.Image = global::DVLD_Presentation.Properties.Resources.PersonDetails_32;
            this.showApplicationDetailsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.showApplicationDetailsToolStripMenuItem.Name = "showApplicationDetailsToolStripMenuItem";
            this.showApplicationDetailsToolStripMenuItem.Size = new System.Drawing.Size(308, 38);
            this.showApplicationDetailsToolStripMenuItem.Text = "&Show Application Details";
            this.showApplicationDetailsToolStripMenuItem.Click += new System.EventHandler(this.showApplicationDetailsToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(305, 6);
            // 
            // editApplicationToolStripMenuItem
            // 
            this.editApplicationToolStripMenuItem.Image = global::DVLD_Presentation.Properties.Resources.edit_32;
            this.editApplicationToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.editApplicationToolStripMenuItem.Name = "editApplicationToolStripMenuItem";
            this.editApplicationToolStripMenuItem.Size = new System.Drawing.Size(308, 38);
            this.editApplicationToolStripMenuItem.Text = "&Edit Application";
            this.editApplicationToolStripMenuItem.Click += new System.EventHandler(this.editApplicationToolStripMenuItem_Click);
            // 
            // deleteApplicationToolStripMenuItem
            // 
            this.deleteApplicationToolStripMenuItem.Image = global::DVLD_Presentation.Properties.Resources.Delete_32_2;
            this.deleteApplicationToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.deleteApplicationToolStripMenuItem.Name = "deleteApplicationToolStripMenuItem";
            this.deleteApplicationToolStripMenuItem.Size = new System.Drawing.Size(308, 38);
            this.deleteApplicationToolStripMenuItem.Text = "&Delete Application";
            this.deleteApplicationToolStripMenuItem.Click += new System.EventHandler(this.deleteApplicationToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(305, 6);
            // 
            // cancelApplicationToolStripMenuItem
            // 
            this.cancelApplicationToolStripMenuItem.Image = global::DVLD_Presentation.Properties.Resources.Delete_32;
            this.cancelApplicationToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.cancelApplicationToolStripMenuItem.Name = "cancelApplicationToolStripMenuItem";
            this.cancelApplicationToolStripMenuItem.Size = new System.Drawing.Size(308, 38);
            this.cancelApplicationToolStripMenuItem.Text = "Cancel Application";
            this.cancelApplicationToolStripMenuItem.Click += new System.EventHandler(this.cancelApplicationToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(305, 6);
            // 
            // scheduleTestsToolStripMenuItem
            // 
            this.scheduleTestsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.scheduleVisionTestToolStripMenuItem,
            this.scheduleWrittenTestToolStripMenuItem,
            this.scheduleStreetTestToolStripMenuItem});
            this.scheduleTestsToolStripMenuItem.Image = global::DVLD_Presentation.Properties.Resources.Schedule_Test_32;
            this.scheduleTestsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.scheduleTestsToolStripMenuItem.Name = "scheduleTestsToolStripMenuItem";
            this.scheduleTestsToolStripMenuItem.Size = new System.Drawing.Size(308, 38);
            this.scheduleTestsToolStripMenuItem.Text = "Schedule Tests";
            // 
            // scheduleVisionTestToolStripMenuItem
            // 
            this.scheduleVisionTestToolStripMenuItem.Image = global::DVLD_Presentation.Properties.Resources.Vision_Test_Schdule;
            this.scheduleVisionTestToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.scheduleVisionTestToolStripMenuItem.Name = "scheduleVisionTestToolStripMenuItem";
            this.scheduleVisionTestToolStripMenuItem.Size = new System.Drawing.Size(247, 38);
            this.scheduleVisionTestToolStripMenuItem.Text = "Schedule Vision Test";
            this.scheduleVisionTestToolStripMenuItem.Click += new System.EventHandler(this.scheduleVisionTestToolStripMenuItem_Click);
            // 
            // scheduleWrittenTestToolStripMenuItem
            // 
            this.scheduleWrittenTestToolStripMenuItem.Image = global::DVLD_Presentation.Properties.Resources.Written_Test_32_Sechdule;
            this.scheduleWrittenTestToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.scheduleWrittenTestToolStripMenuItem.Name = "scheduleWrittenTestToolStripMenuItem";
            this.scheduleWrittenTestToolStripMenuItem.Size = new System.Drawing.Size(247, 38);
            this.scheduleWrittenTestToolStripMenuItem.Text = "Schedule Written Test";
            this.scheduleWrittenTestToolStripMenuItem.Click += new System.EventHandler(this.scheduleWrittenTestToolStripMenuItem_Click);
            // 
            // scheduleStreetTestToolStripMenuItem
            // 
            this.scheduleStreetTestToolStripMenuItem.Image = global::DVLD_Presentation.Properties.Resources.Street_Test_32;
            this.scheduleStreetTestToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.scheduleStreetTestToolStripMenuItem.Name = "scheduleStreetTestToolStripMenuItem";
            this.scheduleStreetTestToolStripMenuItem.Size = new System.Drawing.Size(247, 38);
            this.scheduleStreetTestToolStripMenuItem.Text = "Schedule Street Test";
            this.scheduleStreetTestToolStripMenuItem.Click += new System.EventHandler(this.scheduleStreetTestToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(305, 6);
            // 
            // issueDrivingLicenseFirstTimeToolStripMenuItem
            // 
            this.issueDrivingLicenseFirstTimeToolStripMenuItem.Image = global::DVLD_Presentation.Properties.Resources.IssueDrivingLicense_32;
            this.issueDrivingLicenseFirstTimeToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.issueDrivingLicenseFirstTimeToolStripMenuItem.Name = "issueDrivingLicenseFirstTimeToolStripMenuItem";
            this.issueDrivingLicenseFirstTimeToolStripMenuItem.Size = new System.Drawing.Size(308, 38);
            this.issueDrivingLicenseFirstTimeToolStripMenuItem.Text = "Issue Driving License (First Time)";
            this.issueDrivingLicenseFirstTimeToolStripMenuItem.Click += new System.EventHandler(this.issueDrivingLicenseFirstTimeToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(305, 6);
            // 
            // showLicenseToolStripMenuItem
            // 
            this.showLicenseToolStripMenuItem.Image = global::DVLD_Presentation.Properties.Resources.License_View_32;
            this.showLicenseToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.showLicenseToolStripMenuItem.Name = "showLicenseToolStripMenuItem";
            this.showLicenseToolStripMenuItem.Size = new System.Drawing.Size(308, 38);
            this.showLicenseToolStripMenuItem.Text = "Show License";
            this.showLicenseToolStripMenuItem.Click += new System.EventHandler(this.showLicenseToolStripMenuItem_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(305, 6);
            // 
            // showPersonLicenseHistoryToolStripMenuItem
            // 
            this.showPersonLicenseHistoryToolStripMenuItem.Image = global::DVLD_Presentation.Properties.Resources.PersonLicenseHistory_32;
            this.showPersonLicenseHistoryToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.showPersonLicenseHistoryToolStripMenuItem.Name = "showPersonLicenseHistoryToolStripMenuItem";
            this.showPersonLicenseHistoryToolStripMenuItem.Size = new System.Drawing.Size(308, 38);
            this.showPersonLicenseHistoryToolStripMenuItem.Text = "Show Person License History";
            this.showPersonLicenseHistoryToolStripMenuItem.Click += new System.EventHandler(this.showPersonLicenseHistoryToolStripMenuItem_Click);
            // 
            // btnAddLocalDLApplication
            // 
            this.btnAddLocalDLApplication.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddLocalDLApplication.Image = global::DVLD_Presentation.Properties.Resources.New_Application_64;
            this.btnAddLocalDLApplication.Location = new System.Drawing.Point(1394, 243);
            this.btnAddLocalDLApplication.Name = "btnAddLocalDLApplication";
            this.btnAddLocalDLApplication.Size = new System.Drawing.Size(92, 75);
            this.btnAddLocalDLApplication.TabIndex = 5;
            this.btnAddLocalDLApplication.UseVisualStyleBackColor = true;
            this.btnAddLocalDLApplication.Click += new System.EventHandler(this.btnAddLocalDLApplication_Click);
            // 
            // ctrlCloseButton1
            // 
            this.ctrlCloseButton1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ctrlCloseButton1.Image = ((System.Drawing.Image)(resources.GetObject("ctrlCloseButton1.Image")));
            this.ctrlCloseButton1.Location = new System.Drawing.Point(1318, 687);
            this.ctrlCloseButton1.Name = "ctrlCloseButton1";
            this.ctrlCloseButton1.Size = new System.Drawing.Size(168, 42);
            this.ctrlCloseButton1.TabIndex = 4;
            this.ctrlCloseButton1.Text = "ctrlCloseButton1";
            this.ctrlCloseButton1.UseVisualStyleBackColor = true;
            // 
            // pbSubHeader
            // 
            this.pbSubHeader.Image = global::DVLD_Presentation.Properties.Resources.Local_32;
            this.pbSubHeader.Location = new System.Drawing.Point(809, 79);
            this.pbSubHeader.Name = "pbSubHeader";
            this.pbSubHeader.Size = new System.Drawing.Size(53, 54);
            this.pbSubHeader.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSubHeader.TabIndex = 1;
            this.pbSubHeader.TabStop = false;
            // 
            // pbHeader
            // 
            this.pbHeader.Image = global::DVLD_Presentation.Properties.Resources.Applications;
            this.pbHeader.Location = new System.Drawing.Point(639, 12);
            this.pbHeader.Name = "pbHeader";
            this.pbHeader.Size = new System.Drawing.Size(194, 197);
            this.pbHeader.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbHeader.TabIndex = 0;
            this.pbHeader.TabStop = false;
            // 
            // frmListLocalDrivingLicenseApplications
            // 
            this.AcceptButton = this.btnAddLocalDLApplication;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.ctrlCloseButton1;
            this.ClientSize = new System.Drawing.Size(1504, 741);
            this.Controls.Add(this.btnAddLocalDLApplication);
            this.Controls.Add(this.ctrlCloseButton1);
            this.Controls.Add(this.dlLocalDrivingLicenseApplications);
            this.Controls.Add(this.ctrlTitle1);
            this.Controls.Add(this.pbSubHeader);
            this.Controls.Add(this.pbHeader);
            this.Name = "frmListLocalDrivingLicenseApplications";
            this.Text = "Local Driving License Applications";
            this.Load += new System.EventHandler(this.frmListLocalDrivingLicenseApplications_Load);
            this.cmsLocalDrivingLicenseApplications.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbSubHeader)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHeader)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbHeader;
        private System.Windows.Forms.PictureBox pbSubHeader;
        private Global_Controls.ctrlTitle ctrlTitle1;
        private Global_Controls.ctrlDataListWithFilter dlLocalDrivingLicenseApplications;
        private ctrlCloseButton ctrlCloseButton1;
        private System.Windows.Forms.Button btnAddLocalDLApplication;
        private System.Windows.Forms.ContextMenuStrip cmsLocalDrivingLicenseApplications;
        private System.Windows.Forms.ToolStripMenuItem showApplicationDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem editApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem cancelApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem scheduleTestsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem issueDrivingLicenseFirstTimeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scheduleVisionTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scheduleWrittenTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scheduleStreetTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showPersonLicenseHistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
    }
}