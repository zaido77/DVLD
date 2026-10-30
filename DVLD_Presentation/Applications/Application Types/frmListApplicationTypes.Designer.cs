namespace DVLD_Presentation.Applications.Application_Types
{
    partial class frmListApplicationTypes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListApplicationTypes));
            this.dlApplicationTypes = new DVLD_Presentation.Global_Controls.ctrlDataList();
            this.cmsApplicationTypes = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editApplicationTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pbHeader = new System.Windows.Forms.PictureBox();
            this.ctrlTitle1 = new DVLD_Presentation.Global_Controls.ctrlTitle();
            this.ctrlCloseButton1 = new DVLD_Presentation.ctrlCloseButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.cmsApplicationTypes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbHeader)).BeginInit();
            this.SuspendLayout();
            // 
            // dlApplicationTypes
            // 
            this.dlApplicationTypes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.None;
            this.dlApplicationTypes.BackColor = System.Drawing.Color.White;
            this.dlApplicationTypes.ContextMenuStrip = this.cmsApplicationTypes;
            this.dlApplicationTypes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dlApplicationTypes.Location = new System.Drawing.Point(13, 356);
            this.dlApplicationTypes.Margin = new System.Windows.Forms.Padding(4);
            this.dlApplicationTypes.Name = "dlApplicationTypes";
            this.dlApplicationTypes.Size = new System.Drawing.Size(808, 408);
            this.dlApplicationTypes.TabIndex = 2;
            // 
            // cmsApplicationTypes
            // 
            this.cmsApplicationTypes.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmsApplicationTypes.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsApplicationTypes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.editApplicationTypeToolStripMenuItem,
            this.toolStripSeparator2});
            this.cmsApplicationTypes.Name = "cmsApplicationTypes";
            this.cmsApplicationTypes.Size = new System.Drawing.Size(257, 54);
            // 
            // editApplicationTypeToolStripMenuItem
            // 
            this.editApplicationTypeToolStripMenuItem.Image = global::DVLD_Presentation.Properties.Resources.edit_32;
            this.editApplicationTypeToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.editApplicationTypeToolStripMenuItem.Name = "editApplicationTypeToolStripMenuItem";
            this.editApplicationTypeToolStripMenuItem.Size = new System.Drawing.Size(256, 38);
            this.editApplicationTypeToolStripMenuItem.Text = "Edit Application Type";
            this.editApplicationTypeToolStripMenuItem.Click += new System.EventHandler(this.editApplicationTypeToolStripMenuItem_Click);
            // 
            // pbHeader
            // 
            this.pbHeader.Image = global::DVLD_Presentation.Properties.Resources.Application_Types_512;
            this.pbHeader.Location = new System.Drawing.Point(265, 22);
            this.pbHeader.Name = "pbHeader";
            this.pbHeader.Size = new System.Drawing.Size(304, 241);
            this.pbHeader.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbHeader.TabIndex = 3;
            this.pbHeader.TabStop = false;
            // 
            // ctrlTitle1
            // 
            this.ctrlTitle1.Location = new System.Drawing.Point(53, 274);
            this.ctrlTitle1.Name = "ctrlTitle1";
            this.ctrlTitle1.Size = new System.Drawing.Size(728, 54);
            this.ctrlTitle1.TabIndex = 4;
            this.ctrlTitle1.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.ctrlTitle1.TitleText = "Manage Application Types";
            // 
            // ctrlCloseButton1
            // 
            this.ctrlCloseButton1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ctrlCloseButton1.Image = ((System.Drawing.Image)(resources.GetObject("ctrlCloseButton1.Image")));
            this.ctrlCloseButton1.Location = new System.Drawing.Point(680, 736);
            this.ctrlCloseButton1.Name = "ctrlCloseButton1";
            this.ctrlCloseButton1.Size = new System.Drawing.Size(135, 41);
            this.ctrlCloseButton1.TabIndex = 5;
            this.ctrlCloseButton1.Text = "ctrlCloseButton1";
            this.ctrlCloseButton1.UseVisualStyleBackColor = true;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(253, 6);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(253, 6);
            // 
            // frmListApplicationTypes
            // 
            this.AcceptButton = this.ctrlCloseButton1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.ctrlCloseButton1;
            this.ClientSize = new System.Drawing.Size(834, 794);
            this.Controls.Add(this.ctrlCloseButton1);
            this.Controls.Add(this.ctrlTitle1);
            this.Controls.Add(this.pbHeader);
            this.Controls.Add(this.dlApplicationTypes);
            this.Name = "frmListApplicationTypes";
            this.Text = "Manage Application Types";
            this.Load += new System.EventHandler(this.frmListApplicationTypes_Load);
            this.cmsApplicationTypes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbHeader)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Global_Controls.ctrlDataList dlApplicationTypes;
        private System.Windows.Forms.PictureBox pbHeader;
        private Global_Controls.ctrlTitle ctrlTitle1;
        private ctrlCloseButton ctrlCloseButton1;
        private System.Windows.Forms.ContextMenuStrip cmsApplicationTypes;
        private System.Windows.Forms.ToolStripMenuItem editApplicationTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    }
}