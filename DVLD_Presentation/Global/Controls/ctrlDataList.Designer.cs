namespace DVLD_Presentation.Global_Controls
{
    partial class ctrlDataList
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
            this.lblRecordsCount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvRecords = new System.Windows.Forms.DataGridView();
            this.pnlDataGridView = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecords)).BeginInit();
            this.pnlDataGridView.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblRecordsCount
            // 
            this.lblRecordsCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblRecordsCount.AutoSize = true;
            this.lblRecordsCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.lblRecordsCount.Location = new System.Drawing.Point(107, 420);
            this.lblRecordsCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRecordsCount.Name = "lblRecordsCount";
            this.lblRecordsCount.Size = new System.Drawing.Size(27, 20);
            this.lblRecordsCount.TabIndex = 59;
            this.lblRecordsCount.Text = "??";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 420);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 20);
            this.label2.TabIndex = 58;
            this.label2.Text = "# Records:";
            // 
            // dgvRecords
            // 
            this.dgvRecords.AllowUserToAddRows = false;
            this.dgvRecords.AllowUserToDeleteRows = false;
            this.dgvRecords.AllowUserToOrderColumns = true;
            this.dgvRecords.BackgroundColor = System.Drawing.Color.White;
            this.dgvRecords.ColumnHeadersHeight = 29;
            this.dgvRecords.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRecords.Location = new System.Drawing.Point(0, 0);
            this.dgvRecords.Margin = new System.Windows.Forms.Padding(4);
            this.dgvRecords.MultiSelect = false;
            this.dgvRecords.Name = "dgvRecords";
            this.dgvRecords.ReadOnly = true;
            this.dgvRecords.RowHeadersWidth = 51;
            this.dgvRecords.RowTemplate.Height = 24;
            this.dgvRecords.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRecords.Size = new System.Drawing.Size(858, 410);
            this.dgvRecords.TabIndex = 57;
            this.dgvRecords.DoubleClick += new System.EventHandler(this.dgvRecords_DoubleClick);
            // 
            // pnlDataGridView
            // 
            this.pnlDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDataGridView.Controls.Add(this.dgvRecords);
            this.pnlDataGridView.Location = new System.Drawing.Point(4, 3);
            this.pnlDataGridView.Name = "pnlDataGridView";
            this.pnlDataGridView.Size = new System.Drawing.Size(858, 410);
            this.pnlDataGridView.TabIndex = 60;
            // 
            // ctrlDataList
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblRecordsCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pnlDataGridView);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ctrlDataList";
            this.Size = new System.Drawing.Size(867, 447);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecords)).EndInit();
            this.pnlDataGridView.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.Label lblRecordsCount;
        protected System.Windows.Forms.Label label2;
        protected System.Windows.Forms.DataGridView dgvRecords;
        protected System.Windows.Forms.Panel pnlDataGridView;
    }
}
