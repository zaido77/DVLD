namespace DVLD_Presentation.Tests.Test_Appointments
{
    partial class frmListTestAppointments
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListTestAppointments));
            this.ctrlTitle1 = new DVLD_Presentation.Global_Controls.ctrlTitle();
            this.ctrlLocalDrivingLicenseApplicationCard1 = new DVLD_Presentation.Applications.Local_Driving_License_Applications.ctrlLocalDrivingLicenseApplicationCard();
            this.dlAppointments = new DVLD_Presentation.Global_Controls.ctrlDataList();
            this.cmsTestAppointments = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.takeTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddAppointment = new System.Windows.Forms.Button();
            this.ctrlCloseButton1 = new DVLD_Presentation.ctrlCloseButton();
            this.pbTestType = new System.Windows.Forms.PictureBox();
            this.cmsTestAppointments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTestType)).BeginInit();
            this.SuspendLayout();
            // 
            // ctrlTitle1
            // 
            this.ctrlTitle1.Location = new System.Drawing.Point(96, 143);
            this.ctrlTitle1.Name = "ctrlTitle1";
            this.ctrlTitle1.Size = new System.Drawing.Size(779, 54);
            this.ctrlTitle1.TabIndex = 0;
            this.ctrlTitle1.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.ctrlTitle1.TitleText = "[???] Test Appointments";
            // 
            // ctrlLocalDrivingLicenseApplicationCard1
            // 
            this.ctrlLocalDrivingLicenseApplicationCard1.BackColor = System.Drawing.Color.White;
            this.ctrlLocalDrivingLicenseApplicationCard1.Location = new System.Drawing.Point(2, 214);
            this.ctrlLocalDrivingLicenseApplicationCard1.Name = "ctrlLocalDrivingLicenseApplicationCard1";
            this.ctrlLocalDrivingLicenseApplicationCard1.Size = new System.Drawing.Size(967, 402);
            this.ctrlLocalDrivingLicenseApplicationCard1.TabIndex = 2;
            // 
            // dlAppointments
            // 
            this.dlAppointments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.None;
            this.dlAppointments.BackColor = System.Drawing.Color.White;
            this.dlAppointments.ContextMenuStrip = this.cmsTestAppointments;
            this.dlAppointments.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dlAppointments.Location = new System.Drawing.Point(13, 659);
            this.dlAppointments.Margin = new System.Windows.Forms.Padding(4);
            this.dlAppointments.Name = "dlAppointments";
            this.dlAppointments.Size = new System.Drawing.Size(955, 222);
            this.dlAppointments.TabIndex = 3;
            // 
            // cmsTestAppointments
            // 
            this.cmsTestAppointments.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsTestAppointments.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.takeTestToolStripMenuItem});
            this.cmsTestAppointments.Name = "cmsTestAppointments";
            this.cmsTestAppointments.Size = new System.Drawing.Size(227, 108);
            this.cmsTestAppointments.Opening += new System.ComponentModel.CancelEventHandler(this.cmsTestAppointments_Opening);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Image = global::DVLD_Presentation.Properties.Resources.edit_32;
            this.editToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(226, 38);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // takeTestToolStripMenuItem
            // 
            this.takeTestToolStripMenuItem.Image = global::DVLD_Presentation.Properties.Resources.Test_32;
            this.takeTestToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.takeTestToolStripMenuItem.Name = "takeTestToolStripMenuItem";
            this.takeTestToolStripMenuItem.Size = new System.Drawing.Size(226, 38);
            this.takeTestToolStripMenuItem.Text = "Take Test";
            this.takeTestToolStripMenuItem.Click += new System.EventHandler(this.takeTestToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(20, 636);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Appointments:";
            // 
            // btnAddAppointment
            // 
            this.btnAddAppointment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddAppointment.Image = global::DVLD_Presentation.Properties.Resources.AddAppointment_32;
            this.btnAddAppointment.Location = new System.Drawing.Point(913, 613);
            this.btnAddAppointment.Name = "btnAddAppointment";
            this.btnAddAppointment.Size = new System.Drawing.Size(50, 45);
            this.btnAddAppointment.TabIndex = 6;
            this.btnAddAppointment.UseVisualStyleBackColor = true;
            this.btnAddAppointment.Click += new System.EventHandler(this.btnAddAppointment_Click);
            // 
            // ctrlCloseButton1
            // 
            this.ctrlCloseButton1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ctrlCloseButton1.Image = ((System.Drawing.Image)(resources.GetObject("ctrlCloseButton1.Image")));
            this.ctrlCloseButton1.Location = new System.Drawing.Point(806, 854);
            this.ctrlCloseButton1.Name = "ctrlCloseButton1";
            this.ctrlCloseButton1.Size = new System.Drawing.Size(156, 41);
            this.ctrlCloseButton1.TabIndex = 4;
            this.ctrlCloseButton1.Text = "ctrlCloseButton1";
            this.ctrlCloseButton1.UseVisualStyleBackColor = true;
            // 
            // pbTestType
            // 
            this.pbTestType.Image = global::DVLD_Presentation.Properties.Resources.Vision_512;
            this.pbTestType.Location = new System.Drawing.Point(410, 12);
            this.pbTestType.Name = "pbTestType";
            this.pbTestType.Size = new System.Drawing.Size(150, 125);
            this.pbTestType.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbTestType.TabIndex = 1;
            this.pbTestType.TabStop = false;
            // 
            // frmTestAppointments
            // 
            this.AcceptButton = this.btnAddAppointment;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.ctrlCloseButton1;
            this.ClientSize = new System.Drawing.Size(973, 902);
            this.Controls.Add(this.btnAddAppointment);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ctrlCloseButton1);
            this.Controls.Add(this.dlAppointments);
            this.Controls.Add(this.ctrlLocalDrivingLicenseApplicationCard1);
            this.Controls.Add(this.pbTestType);
            this.Controls.Add(this.ctrlTitle1);
            this.Name = "frmTestAppointments";
            this.Text = "Test Appointments";
            this.Load += new System.EventHandler(this.frmTestAppointments_Load);
            this.cmsTestAppointments.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbTestType)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Global_Controls.ctrlTitle ctrlTitle1;
        private System.Windows.Forms.PictureBox pbTestType;
        private Applications.Local_Driving_License_Applications.ctrlLocalDrivingLicenseApplicationCard ctrlLocalDrivingLicenseApplicationCard1;
        private Global_Controls.ctrlDataList dlAppointments;
        private ctrlCloseButton ctrlCloseButton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddAppointment;
        private System.Windows.Forms.ContextMenuStrip cmsTestAppointments;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem takeTestToolStripMenuItem;
    }
}