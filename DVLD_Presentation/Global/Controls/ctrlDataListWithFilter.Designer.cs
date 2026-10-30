namespace DVLD_Presentation.Global_Controls
{
    partial class ctrlDataListWithFilter
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
            this.cbAllYesNo = new System.Windows.Forms.ComboBox();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.cbFilterBy = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblRecordsCount
            // 
            this.lblRecordsCount.Location = new System.Drawing.Point(109, 426);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(7, 426);
            // 
            // pnlDataGridView
            // 
            this.pnlDataGridView.Location = new System.Drawing.Point(4, 40);
            this.pnlDataGridView.Size = new System.Drawing.Size(858, 379);
            // 
            // cbAllYesNo
            // 
            this.cbAllYesNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAllYesNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbAllYesNo.FormattingEnabled = true;
            this.cbAllYesNo.Items.AddRange(new object[] {
            "All",
            "Yes",
            "No"});
            this.cbAllYesNo.Location = new System.Drawing.Point(331, 5);
            this.cbAllYesNo.Name = "cbAllYesNo";
            this.cbAllYesNo.Size = new System.Drawing.Size(129, 28);
            this.cbAllYesNo.TabIndex = 66;
            this.cbAllYesNo.Visible = false;
            this.cbAllYesNo.SelectedIndexChanged += new System.EventHandler(this.cbAllYesNo_SelectedIndexChanged);
            // 
            // txtFilter
            // 
            this.txtFilter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtFilter.Location = new System.Drawing.Point(331, 6);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(239, 26);
            this.txtFilter.TabIndex = 65;
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            this.txtFilter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFilter_KeyPress);
            // 
            // cbFilterBy
            // 
            this.cbFilterBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilterBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbFilterBy.FormattingEnabled = true;
            this.cbFilterBy.Location = new System.Drawing.Point(110, 6);
            this.cbFilterBy.Name = "cbFilterBy";
            this.cbFilterBy.Size = new System.Drawing.Size(215, 28);
            this.cbFilterBy.TabIndex = 64;
            this.cbFilterBy.SelectedIndexChanged += new System.EventHandler(this.cbFilterBy_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 63;
            this.label1.Text = "Filter By:";
            // 
            // ctrlDataListWithFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cbAllYesNo);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.cbFilterBy);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "ctrlDataListWithFilter";
            this.Size = new System.Drawing.Size(867, 450);
            this.Controls.SetChildIndex(this.pnlDataGridView, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.lblRecordsCount, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.cbFilterBy, 0);
            this.Controls.SetChildIndex(this.txtFilter, 0);
            this.Controls.SetChildIndex(this.cbAllYesNo, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbAllYesNo;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.ComboBox cbFilterBy;
        private System.Windows.Forms.Label label1;
    }
}
