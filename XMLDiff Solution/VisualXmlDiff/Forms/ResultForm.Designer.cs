namespace VisualXmlDiff.Forms
{
    partial class ResultForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Diff_TabPControl = new System.Windows.Forms.TabControl();
            this.Summary_TabPage = new System.Windows.Forms.TabPage();
            this.Summary_GridView = new System.Windows.Forms.DataGridView();
            this.TestCaseName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Result = new System.Windows.Forms.DataGridViewImageColumn();
            this.Missed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Details_TabPage = new System.Windows.Forms.TabPage();
            this.Result_Browser = new System.Windows.Forms.WebBrowser();
            this.SummaryDataTime_Label = new System.Windows.Forms.Label();
            this.Diff_TabPControl.SuspendLayout();
            this.Summary_TabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Summary_GridView)).BeginInit();
            this.Details_TabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // Diff_TabPControl
            // 
            this.Diff_TabPControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Diff_TabPControl.Controls.Add(this.Summary_TabPage);
            this.Diff_TabPControl.Controls.Add(this.Details_TabPage);
            this.Diff_TabPControl.Location = new System.Drawing.Point(12, 45);
            this.Diff_TabPControl.Name = "Diff_TabPControl";
            this.Diff_TabPControl.SelectedIndex = 0;
            this.Diff_TabPControl.Size = new System.Drawing.Size(1043, 770);
            this.Diff_TabPControl.TabIndex = 0;
            // 
            // Summary_TabPage
            // 
            this.Summary_TabPage.Controls.Add(this.Summary_GridView);
            this.Summary_TabPage.Location = new System.Drawing.Point(4, 22);
            this.Summary_TabPage.Name = "Summary_TabPage";
            this.Summary_TabPage.Padding = new System.Windows.Forms.Padding(3);
            this.Summary_TabPage.Size = new System.Drawing.Size(1035, 744);
            this.Summary_TabPage.TabIndex = 0;
            this.Summary_TabPage.Text = "Summary";
            this.Summary_TabPage.UseVisualStyleBackColor = true;
            this.Summary_TabPage.Enter += new System.EventHandler(this.Summary_TabPage_Enter);
            // 
            // Summary_GridView
            // 
            this.Summary_GridView.AllowUserToAddRows = false;
            this.Summary_GridView.AllowUserToDeleteRows = false;
            this.Summary_GridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Summary_GridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Summary_GridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Summary_GridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Summary_GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Summary_GridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TestCaseName,
            this.Result,
            this.Missed});
            this.Summary_GridView.Location = new System.Drawing.Point(6, 6);
            this.Summary_GridView.Name = "Summary_GridView";
            this.Summary_GridView.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Summary_GridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Summary_GridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Summary_GridView.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.Summary_GridView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Summary_GridView.RowTemplate.DividerHeight = 2;
            this.Summary_GridView.RowTemplate.Height = 35;
            this.Summary_GridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Summary_GridView.Size = new System.Drawing.Size(1023, 732);
            this.Summary_GridView.TabIndex = 0;
            // 
            // TestCaseName
            // 
            this.TestCaseName.HeaderText = "Name";
            this.TestCaseName.Name = "TestCaseName";
            this.TestCaseName.ReadOnly = true;
            this.TestCaseName.Width = 327;
            // 
            // Result
            // 
            this.Result.HeaderText = "Result";
            this.Result.Name = "Result";
            this.Result.ReadOnly = true;
            this.Result.Width = 326;
            // 
            // Missed
            // 
            this.Missed.HeaderText = "Missed";
            this.Missed.Name = "Missed";
            this.Missed.ReadOnly = true;
            this.Missed.Width = 326;
            // 
            // Details_TabPage
            // 
            this.Details_TabPage.Controls.Add(this.Result_Browser);
            this.Details_TabPage.Location = new System.Drawing.Point(4, 22);
            this.Details_TabPage.Name = "Details_TabPage";
            this.Details_TabPage.Padding = new System.Windows.Forms.Padding(3);
            this.Details_TabPage.Size = new System.Drawing.Size(1035, 744);
            this.Details_TabPage.TabIndex = 1;
            this.Details_TabPage.Text = "Details";
            this.Details_TabPage.UseVisualStyleBackColor = true;
            this.Details_TabPage.Enter += new System.EventHandler(this.Details_TabPage_Enter);
            // 
            // Result_Browser
            // 
            this.Result_Browser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Result_Browser.Location = new System.Drawing.Point(6, 6);
            this.Result_Browser.MinimumSize = new System.Drawing.Size(20, 20);
            this.Result_Browser.Name = "Result_Browser";
            this.Result_Browser.Size = new System.Drawing.Size(1023, 732);
            this.Result_Browser.TabIndex = 1;
            // 
            // SummaryDataTime_Label
            // 
            this.SummaryDataTime_Label.AutoSize = true;
            this.SummaryDataTime_Label.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SummaryDataTime_Label.Location = new System.Drawing.Point(369, 24);
            this.SummaryDataTime_Label.Name = "SummaryDataTime_Label";
            this.SummaryDataTime_Label.Size = new System.Drawing.Size(0, 20);
            this.SummaryDataTime_Label.TabIndex = 1;
            // 
            // ResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 827);
            this.Controls.Add(this.SummaryDataTime_Label);
            this.Controls.Add(this.Diff_TabPControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ResultForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Result";
            this.Diff_TabPControl.ResumeLayout(false);
            this.Summary_TabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Summary_GridView)).EndInit();
            this.Details_TabPage.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl Diff_TabPControl;
        private System.Windows.Forms.TabPage Summary_TabPage;
        private System.Windows.Forms.TabPage Details_TabPage;
        private System.Windows.Forms.WebBrowser Result_Browser;
        private System.Windows.Forms.DataGridView Summary_GridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn TestCaseName;
        private System.Windows.Forms.DataGridViewImageColumn Result;
        private System.Windows.Forms.DataGridViewTextBoxColumn Missed;
        private System.Windows.Forms.Label SummaryDataTime_Label;

    }
}