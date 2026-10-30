namespace DVLD_Presentation.Tests.Test_Types
{
    partial class frmListTestTypes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListTestTypes));
            this.dlTestTypes = new DVLD_Presentation.Global_Controls.ctrlDataList();
            this.cmsTestTypes = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editTestTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ctrlTitle1 = new DVLD_Presentation.Global_Controls.ctrlTitle();
            this.ctrlCloseButton1 = new DVLD_Presentation.ctrlCloseButton();
            this.pbHeader = new System.Windows.Forms.PictureBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.cmsTestTypes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbHeader)).BeginInit();
            this.SuspendLayout();
            // 
            // dlTestTypes
            // 
            this.dlTestTypes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.None;
            this.dlTestTypes.BackColor = System.Drawing.Color.White;
            this.dlTestTypes.ContextMenuStrip = this.cmsTestTypes;
            this.dlTestTypes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dlTestTypes.Location = new System.Drawing.Point(13, 333);
            this.dlTestTypes.Margin = new System.Windows.Forms.Padding(4);
            this.dlTestTypes.Name = "dlTestTypes";
            this.dlTestTypes.Size = new System.Drawing.Size(1035, 408);
            this.dlTestTypes.TabIndex = 6;
            // 
            // cmsTestTypes
            // 
            this.cmsTestTypes.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmsTestTypes.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsTestTypes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.editTestTypeToolStripMenuItem,
            this.toolStripSeparator2});
            this.cmsTestTypes.Name = "cmsApplicationTypes";
            this.cmsTestTypes.Size = new System.Drawing.Size(227, 82);
            // 
            // editTestTypeToolStripMenuItem
            // 
            this.editTestTypeToolStripMenuItem.Image = global::DVLD_Presentation.Properties.Resources.edit_32;
            this.editTestTypeToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.editTestTypeToolStripMenuItem.Name = "editTestTypeToolStripMenuItem";
            this.editTestTypeToolStripMenuItem.Size = new System.Drawing.Size(226, 38);
            this.editTestTypeToolStripMenuItem.Text = "&Edit Test Type";
            this.editTestTypeToolStripMenuItem.Click += new System.EventHandler(this.editTestTypeToolStripMenuItem_Click);
            // 
            // ctrlTitle1
            // 
            this.ctrlTitle1.Location = new System.Drawing.Point(166, 251);
            this.ctrlTitle1.Name = "ctrlTitle1";
            this.ctrlTitle1.Size = new System.Drawing.Size(728, 54);
            this.ctrlTitle1.TabIndex = 8;
            this.ctrlTitle1.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.ctrlTitle1.TitleText = "Manage Test Types";
            // 
            // ctrlCloseButton1
            // 
            this.ctrlCloseButton1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ctrlCloseButton1.Image = ((System.Drawing.Image)(resources.GetObject("ctrlCloseButton1.Image")));
            this.ctrlCloseButton1.Location = new System.Drawing.Point(909, 715);
            this.ctrlCloseButton1.Name = "ctrlCloseButton1";
            this.ctrlCloseButton1.Size = new System.Drawing.Size(135, 41);
            this.ctrlCloseButton1.TabIndex = 9;
            this.ctrlCloseButton1.Text = "ctrlCloseButton1";
            this.ctrlCloseButton1.UseVisualStyleBackColor = true;
            // 
            // pbHeader
            // 
            this.pbHeader.Image = global::DVLD_Presentation.Properties.Resources.TestType_512;
            this.pbHeader.Location = new System.Drawing.Point(386, 12);
            this.pbHeader.Name = "pbHeader";
            this.pbHeader.Size = new System.Drawing.Size(288, 228);
            this.pbHeader.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbHeader.TabIndex = 7;
            this.pbHeader.TabStop = false;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(223, 6);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(223, 6);
            // 
            // frmListTestTypes
            // 
            this.AcceptButton = this.ctrlCloseButton1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.ctrlCloseButton1;
            this.ClientSize = new System.Drawing.Size(1061, 770);
            this.Controls.Add(this.ctrlCloseButton1);
            this.Controls.Add(this.dlTestTypes);
            this.Controls.Add(this.ctrlTitle1);
            this.Controls.Add(this.pbHeader);
            this.Name = "frmListTestTypes";
            this.Text = "Manage Test Types";
            this.Load += new System.EventHandler(this.frmListTestTypes_Load);
            this.cmsTestTypes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbHeader)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Global_Controls.ctrlDataList dlTestTypes;
        private System.Windows.Forms.ContextMenuStrip cmsTestTypes;
        private System.Windows.Forms.ToolStripMenuItem editTestTypeToolStripMenuItem;
        private ctrlCloseButton ctrlCloseButton1;
        private Global_Controls.ctrlTitle ctrlTitle1;
        private System.Windows.Forms.PictureBox pbHeader;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    }
}