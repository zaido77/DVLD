namespace DVLD_Presentation.Applications.Local_Driving_License_Applications
{
    partial class ctrlDriverLicenses
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
            this.gbDriverLicenses = new System.Windows.Forms.GroupBox();
            this.tcDriverLicenses = new System.Windows.Forms.TabControl();
            this.tabLocalLicenses = new System.Windows.Forms.TabPage();
            this.dlLocalLicenses = new DVLD_Presentation.Global_Controls.ctrlDataList();
            this.cmsLocalLicenses = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showLocalLicenseInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.tabInternationalLicenses = new System.Windows.Forms.TabPage();
            this.dlInternationalLicenses = new DVLD_Presentation.Global_Controls.ctrlDataList();
            this.cmsInternationalLicenses = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showInternationalLicenseInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.gbDriverLicenses.SuspendLayout();
            this.tcDriverLicenses.SuspendLayout();
            this.tabLocalLicenses.SuspendLayout();
            this.cmsLocalLicenses.SuspendLayout();
            this.tabInternationalLicenses.SuspendLayout();
            this.cmsInternationalLicenses.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbDriverLicenses
            // 
            this.gbDriverLicenses.Controls.Add(this.tcDriverLicenses);
            this.gbDriverLicenses.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.gbDriverLicenses.Location = new System.Drawing.Point(8, 3);
            this.gbDriverLicenses.Name = "gbDriverLicenses";
            this.gbDriverLicenses.Size = new System.Drawing.Size(1175, 329);
            this.gbDriverLicenses.TabIndex = 0;
            this.gbDriverLicenses.TabStop = false;
            this.gbDriverLicenses.Text = "Driver Licenses";
            // 
            // tcDriverLicenses
            // 
            this.tcDriverLicenses.Controls.Add(this.tabLocalLicenses);
            this.tcDriverLicenses.Controls.Add(this.tabInternationalLicenses);
            this.tcDriverLicenses.Location = new System.Drawing.Point(12, 30);
            this.tcDriverLicenses.Name = "tcDriverLicenses";
            this.tcDriverLicenses.SelectedIndex = 0;
            this.tcDriverLicenses.Size = new System.Drawing.Size(1157, 287);
            this.tcDriverLicenses.TabIndex = 0;
            // 
            // tabLocalLicenses
            // 
            this.tabLocalLicenses.BackColor = System.Drawing.Color.White;
            this.tabLocalLicenses.Controls.Add(this.dlLocalLicenses);
            this.tabLocalLicenses.Controls.Add(this.label1);
            this.tabLocalLicenses.Location = new System.Drawing.Point(4, 29);
            this.tabLocalLicenses.Name = "tabLocalLicenses";
            this.tabLocalLicenses.Padding = new System.Windows.Forms.Padding(3);
            this.tabLocalLicenses.Size = new System.Drawing.Size(1149, 254);
            this.tabLocalLicenses.TabIndex = 0;
            this.tabLocalLicenses.Text = "Local";
            // 
            // dlLocalLicenses
            // 
            this.dlLocalLicenses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.None;
            this.dlLocalLicenses.BackColor = System.Drawing.Color.White;
            this.dlLocalLicenses.ContextMenuStrip = this.cmsLocalLicenses;
            this.dlLocalLicenses.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dlLocalLicenses.Location = new System.Drawing.Point(7, 41);
            this.dlLocalLicenses.Margin = new System.Windows.Forms.Padding(4);
            this.dlLocalLicenses.Name = "dlLocalLicenses";
            this.dlLocalLicenses.Size = new System.Drawing.Size(1136, 212);
            this.dlLocalLicenses.TabIndex = 3;
            this.dlLocalLicenses.RowDoubleClick += new System.EventHandler(this.dlLocalLicenses_RowDoubleClick);
            // 
            // cmsLocalLicenses
            // 
            this.cmsLocalLicenses.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsLocalLicenses.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showLocalLicenseInfoToolStripMenuItem});
            this.cmsLocalLicenses.Name = "cmsLocalLicenses";
            this.cmsLocalLicenses.Size = new System.Drawing.Size(213, 42);
            this.cmsLocalLicenses.Opening += new System.ComponentModel.CancelEventHandler(this.cmsLocalLicenses_Opening);
            // 
            // showLocalLicenseInfoToolStripMenuItem
            // 
            this.showLocalLicenseInfoToolStripMenuItem.Image = global::DVLD_Presentation.Properties.Resources.License_View_32;
            this.showLocalLicenseInfoToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.showLocalLicenseInfoToolStripMenuItem.Name = "showLocalLicenseInfoToolStripMenuItem";
            this.showLocalLicenseInfoToolStripMenuItem.Size = new System.Drawing.Size(226, 38);
            this.showLocalLicenseInfoToolStripMenuItem.Text = "Show License Info";
            this.showLocalLicenseInfoToolStripMenuItem.Click += new System.EventHandler(this.showLocalLicenseInfoToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Local Licenses History:";
            // 
            // tabInternationalLicenses
            // 
            this.tabInternationalLicenses.BackColor = System.Drawing.Color.White;
            this.tabInternationalLicenses.Controls.Add(this.dlInternationalLicenses);
            this.tabInternationalLicenses.Controls.Add(this.label2);
            this.tabInternationalLicenses.Location = new System.Drawing.Point(4, 29);
            this.tabInternationalLicenses.Name = "tabInternationalLicenses";
            this.tabInternationalLicenses.Padding = new System.Windows.Forms.Padding(3);
            this.tabInternationalLicenses.Size = new System.Drawing.Size(1149, 254);
            this.tabInternationalLicenses.TabIndex = 1;
            this.tabInternationalLicenses.Text = "International";
            // 
            // dlInternationalLicenses
            // 
            this.dlInternationalLicenses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.None;
            this.dlInternationalLicenses.BackColor = System.Drawing.Color.White;
            this.dlInternationalLicenses.ContextMenuStrip = this.cmsInternationalLicenses;
            this.dlInternationalLicenses.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dlInternationalLicenses.Location = new System.Drawing.Point(7, 41);
            this.dlInternationalLicenses.Margin = new System.Windows.Forms.Padding(4);
            this.dlInternationalLicenses.Name = "dlInternationalLicenses";
            this.dlInternationalLicenses.Size = new System.Drawing.Size(1136, 212);
            this.dlInternationalLicenses.TabIndex = 5;
            this.dlInternationalLicenses.RowDoubleClick += new System.EventHandler(this.dlInternationalLicenses_RowDoubleClick);
            // 
            // cmsInternationalLicenses
            // 
            this.cmsInternationalLicenses.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsInternationalLicenses.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showInternationalLicenseInfoToolStripMenuItem});
            this.cmsInternationalLicenses.Name = "cmsLocalLicenses";
            this.cmsInternationalLicenses.Size = new System.Drawing.Size(227, 70);
            this.cmsInternationalLicenses.Opening += new System.ComponentModel.CancelEventHandler(this.cmsInternationalLicenses_Opening);
            // 
            // showInternationalLicenseInfoToolStripMenuItem
            // 
            this.showInternationalLicenseInfoToolStripMenuItem.Image = global::DVLD_Presentation.Properties.Resources.License_View_32;
            this.showInternationalLicenseInfoToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.showInternationalLicenseInfoToolStripMenuItem.Name = "showInternationalLicenseInfoToolStripMenuItem";
            this.showInternationalLicenseInfoToolStripMenuItem.Size = new System.Drawing.Size(212, 38);
            this.showInternationalLicenseInfoToolStripMenuItem.Text = "Show License Info";
            this.showInternationalLicenseInfoToolStripMenuItem.Click += new System.EventHandler(this.showInternationalLicenseInfoToolStripMenuItem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(268, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "International Licenses History:";
            // 
            // ctrlDriverLicenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.gbDriverLicenses);
            this.Name = "ctrlDriverLicenses";
            this.Size = new System.Drawing.Size(1193, 341);
            this.gbDriverLicenses.ResumeLayout(false);
            this.tcDriverLicenses.ResumeLayout(false);
            this.tabLocalLicenses.ResumeLayout(false);
            this.tabLocalLicenses.PerformLayout();
            this.cmsLocalLicenses.ResumeLayout(false);
            this.tabInternationalLicenses.ResumeLayout(false);
            this.tabInternationalLicenses.PerformLayout();
            this.cmsInternationalLicenses.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDriverLicenses;
        private System.Windows.Forms.TabControl tcDriverLicenses;
        private System.Windows.Forms.TabPage tabLocalLicenses;
        private System.Windows.Forms.TabPage tabInternationalLicenses;
        private Global_Controls.ctrlDataList dlLocalLicenses;
        private System.Windows.Forms.Label label1;
        private Global_Controls.ctrlDataList dlInternationalLicenses;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ContextMenuStrip cmsLocalLicenses;
        private System.Windows.Forms.ToolStripMenuItem showLocalLicenseInfoToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip cmsInternationalLicenses;
        private System.Windows.Forms.ToolStripMenuItem showInternationalLicenseInfoToolStripMenuItem;
    }
}
