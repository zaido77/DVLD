namespace DVLD_Presentation.Licenses.Detained_Licenses
{
    partial class frmListDetainedLicenses
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListDetainedLicenses));
            this.dlDetainedLicenses = new DVLD_Presentation.Global_Controls.ctrlDataListWithFilter();
            this.cmsDetainedLicenses = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showLicenseDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showPersonDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showPersonLicenseHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.releaseDetainedLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ctrlTitle1 = new DVLD_Presentation.Global_Controls.ctrlTitle();
            this.btnReleaseDetainedLicense = new System.Windows.Forms.Button();
            this.btnDetainLicense = new System.Windows.Forms.Button();
            this.ctrlCloseButton1 = new DVLD_Presentation.ctrlCloseButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmsDetainedLicenses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dlDetainedLicenses
            // 
            this.dlDetainedLicenses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.None;
            this.dlDetainedLicenses.BackColor = System.Drawing.Color.White;
            this.dlDetainedLicenses.ContextMenuStrip = this.cmsDetainedLicenses;
            this.dlDetainedLicenses.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dlDetainedLicenses.Location = new System.Drawing.Point(14, 303);
            this.dlDetainedLicenses.Margin = new System.Windows.Forms.Padding(5);
            this.dlDetainedLicenses.Name = "dlDetainedLicenses";
            this.dlDetainedLicenses.Size = new System.Drawing.Size(1508, 455);
            this.dlDetainedLicenses.TabIndex = 128;
            // 
            // cmsDetainedLicenses
            // 
            this.cmsDetainedLicenses.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsDetainedLicenses.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showLicenseDetailsToolStripMenuItem,
            this.showPersonDetailsToolStripMenuItem,
            this.showPersonLicenseHistoryToolStripMenuItem,
            this.toolStripSeparator3,
            this.releaseDetainedLicenseToolStripMenuItem});
            this.cmsDetainedLicenses.Name = "contextMenuStrip1";
            this.cmsDetainedLicenses.Size = new System.Drawing.Size(281, 162);
            this.cmsDetainedLicenses.Opening += new System.ComponentModel.CancelEventHandler(this.cmsDetainedLicenses_Opening);
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
            // showPersonDetailsToolStripMenuItem
            // 
            this.showPersonDetailsToolStripMenuItem.Image = global::DVLD_Presentation.Properties.Resources.PersonDetails_32;
            this.showPersonDetailsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.showPersonDetailsToolStripMenuItem.Name = "showPersonDetailsToolStripMenuItem";
            this.showPersonDetailsToolStripMenuItem.Size = new System.Drawing.Size(280, 38);
            this.showPersonDetailsToolStripMenuItem.Text = "&Show Person Details";
            this.showPersonDetailsToolStripMenuItem.Click += new System.EventHandler(this.showPersonDetailsToolStripMenuItem_Click);
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
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(277, 6);
            // 
            // releaseDetainedLicenseToolStripMenuItem
            // 
            this.releaseDetainedLicenseToolStripMenuItem.Image = global::DVLD_Presentation.Properties.Resources.Release_Detained_License_32;
            this.releaseDetainedLicenseToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.releaseDetainedLicenseToolStripMenuItem.Name = "releaseDetainedLicenseToolStripMenuItem";
            this.releaseDetainedLicenseToolStripMenuItem.Size = new System.Drawing.Size(280, 38);
            this.releaseDetainedLicenseToolStripMenuItem.Text = "&Release Detained License";
            this.releaseDetainedLicenseToolStripMenuItem.Click += new System.EventHandler(this.releaseDetainedLicenseToolStripMenuItem_Click);
            // 
            // ctrlTitle1
            // 
            this.ctrlTitle1.Location = new System.Drawing.Point(445, 234);
            this.ctrlTitle1.Name = "ctrlTitle1";
            this.ctrlTitle1.Size = new System.Drawing.Size(647, 54);
            this.ctrlTitle1.TabIndex = 130;
            this.ctrlTitle1.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold);
            this.ctrlTitle1.TitleText = "List Detained Licenses";
            // 
            // btnReleaseDetainedLicense
            // 
            this.btnReleaseDetainedLicense.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReleaseDetainedLicense.Image = global::DVLD_Presentation.Properties.Resources.Release_Detained_License_64;
            this.btnReleaseDetainedLicense.Location = new System.Drawing.Point(1293, 249);
            this.btnReleaseDetainedLicense.Name = "btnReleaseDetainedLicense";
            this.btnReleaseDetainedLicense.Size = new System.Drawing.Size(108, 85);
            this.btnReleaseDetainedLicense.TabIndex = 132;
            this.btnReleaseDetainedLicense.UseVisualStyleBackColor = true;
            this.btnReleaseDetainedLicense.Click += new System.EventHandler(this.btnReleaseDetainedLicense_Click);
            // 
            // btnDetainLicense
            // 
            this.btnDetainLicense.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetainLicense.Image = global::DVLD_Presentation.Properties.Resources.Detain_64;
            this.btnDetainLicense.Location = new System.Drawing.Point(1410, 249);
            this.btnDetainLicense.Name = "btnDetainLicense";
            this.btnDetainLicense.Size = new System.Drawing.Size(108, 85);
            this.btnDetainLicense.TabIndex = 131;
            this.btnDetainLicense.UseVisualStyleBackColor = true;
            this.btnDetainLicense.Click += new System.EventHandler(this.btnDetainLicense_Click);
            // 
            // ctrlCloseButton1
            // 
            this.ctrlCloseButton1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ctrlCloseButton1.Image = ((System.Drawing.Image)(resources.GetObject("ctrlCloseButton1.Image")));
            this.ctrlCloseButton1.Location = new System.Drawing.Point(1346, 733);
            this.ctrlCloseButton1.Name = "ctrlCloseButton1";
            this.ctrlCloseButton1.Size = new System.Drawing.Size(172, 41);
            this.ctrlCloseButton1.TabIndex = 129;
            this.ctrlCloseButton1.Text = "ctrlCloseButton1";
            this.ctrlCloseButton1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = global::DVLD_Presentation.Properties.Resources.Detain_512;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(625, 14);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(286, 212);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 127;
            this.pictureBox1.TabStop = false;
            // 
            // frmListDetainedLicenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.ctrlCloseButton1;
            this.ClientSize = new System.Drawing.Size(1531, 784);
            this.Controls.Add(this.btnReleaseDetainedLicense);
            this.Controls.Add(this.btnDetainLicense);
            this.Controls.Add(this.ctrlCloseButton1);
            this.Controls.Add(this.dlDetainedLicenses);
            this.Controls.Add(this.ctrlTitle1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmListDetainedLicenses";
            this.Text = "List Detained Licenses";
            this.Load += new System.EventHandler(this.frmListDetainedLicenses_Load);
            this.cmsDetainedLicenses.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Global_Controls.ctrlDataListWithFilter dlDetainedLicenses;
        private Global_Controls.ctrlTitle ctrlTitle1;
        private ctrlCloseButton ctrlCloseButton1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnDetainLicense;
        private System.Windows.Forms.Button btnReleaseDetainedLicense;
        private System.Windows.Forms.ContextMenuStrip cmsDetainedLicenses;
        private System.Windows.Forms.ToolStripMenuItem showLicenseDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showPersonDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showPersonLicenseHistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem releaseDetainedLicenseToolStripMenuItem;
    }
}