namespace VisualXmlDiff.Forms
{
    partial class AppConfigForm
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
            this.AppConfigOk_Button = new System.Windows.Forms.Button();
            this.AppConfigCancel_Button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.NewFilesToken_TextBox = new System.Windows.Forms.TextBox();
            this.ReferenceFilesToken_TextBox = new System.Windows.Forms.TextBox();
            this.DiffFilesToken_TextBox = new System.Windows.Forms.TextBox();
            this.MasterFileToken_TextBox = new System.Windows.Forms.TextBox();
            this.SummaryFileToken_TextBox = new System.Windows.Forms.TextBox();
            this.DiffFileName_TextBox = new System.Windows.Forms.TextBox();
            this.FileExtension_TextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Delimiter_TextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // AppConfigOk_Button
            // 
            this.AppConfigOk_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AppConfigOk_Button.Location = new System.Drawing.Point(376, 173);
            this.AppConfigOk_Button.Name = "AppConfigOk_Button";
            this.AppConfigOk_Button.Size = new System.Drawing.Size(87, 27);
            this.AppConfigOk_Button.TabIndex = 8;
            this.AppConfigOk_Button.Text = "Ok";
            this.AppConfigOk_Button.UseVisualStyleBackColor = true;
            this.AppConfigOk_Button.Click += new System.EventHandler(this.AppConfigOk_Button_Click);
            // 
            // AppConfigCancel_Button
            // 
            this.AppConfigCancel_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AppConfigCancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.AppConfigCancel_Button.Location = new System.Drawing.Point(469, 173);
            this.AppConfigCancel_Button.Name = "AppConfigCancel_Button";
            this.AppConfigCancel_Button.Size = new System.Drawing.Size(87, 27);
            this.AppConfigCancel_Button.TabIndex = 9;
            this.AppConfigCancel_Button.Text = "Cancel";
            this.AppConfigCancel_Button.UseVisualStyleBackColor = true;
            this.AppConfigCancel_Button.Click += new System.EventHandler(this.AppConfigCancel_Button_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "New Files Token:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(310, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Reference Files Token:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(51, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Diff Files Token:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(331, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Master File Token:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Summary File Token:";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(57, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 15);
            this.label6.TabIndex = 7;
            this.label6.Text = "Diff File Name:";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(348, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 15);
            this.label7.TabIndex = 8;
            this.label7.Text = "Files Extension:";
            // 
            // NewFilesToken_TextBox
            // 
            this.NewFilesToken_TextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.NewFilesToken_TextBox.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewFilesToken_TextBox.Location = new System.Drawing.Point(148, 46);
            this.NewFilesToken_TextBox.Name = "NewFilesToken_TextBox";
            this.NewFilesToken_TextBox.Size = new System.Drawing.Size(116, 23);
            this.NewFilesToken_TextBox.TabIndex = 0;
            // 
            // ReferenceFilesToken_TextBox
            // 
            this.ReferenceFilesToken_TextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ReferenceFilesToken_TextBox.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReferenceFilesToken_TextBox.Location = new System.Drawing.Point(440, 46);
            this.ReferenceFilesToken_TextBox.Name = "ReferenceFilesToken_TextBox";
            this.ReferenceFilesToken_TextBox.Size = new System.Drawing.Size(116, 23);
            this.ReferenceFilesToken_TextBox.TabIndex = 1;
            // 
            // DiffFilesToken_TextBox
            // 
            this.DiffFilesToken_TextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.DiffFilesToken_TextBox.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DiffFilesToken_TextBox.Location = new System.Drawing.Point(148, 75);
            this.DiffFilesToken_TextBox.Name = "DiffFilesToken_TextBox";
            this.DiffFilesToken_TextBox.Size = new System.Drawing.Size(116, 23);
            this.DiffFilesToken_TextBox.TabIndex = 2;
            // 
            // MasterFileToken_TextBox
            // 
            this.MasterFileToken_TextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.MasterFileToken_TextBox.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MasterFileToken_TextBox.Location = new System.Drawing.Point(440, 75);
            this.MasterFileToken_TextBox.Name = "MasterFileToken_TextBox";
            this.MasterFileToken_TextBox.Size = new System.Drawing.Size(116, 23);
            this.MasterFileToken_TextBox.TabIndex = 3;
            // 
            // SummaryFileToken_TextBox
            // 
            this.SummaryFileToken_TextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.SummaryFileToken_TextBox.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SummaryFileToken_TextBox.Location = new System.Drawing.Point(148, 104);
            this.SummaryFileToken_TextBox.Name = "SummaryFileToken_TextBox";
            this.SummaryFileToken_TextBox.Size = new System.Drawing.Size(116, 23);
            this.SummaryFileToken_TextBox.TabIndex = 4;
            // 
            // DiffFileName_TextBox
            // 
            this.DiffFileName_TextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.DiffFileName_TextBox.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DiffFileName_TextBox.Location = new System.Drawing.Point(148, 133);
            this.DiffFileName_TextBox.Name = "DiffFileName_TextBox";
            this.DiffFileName_TextBox.Size = new System.Drawing.Size(116, 23);
            this.DiffFileName_TextBox.TabIndex = 6;
            // 
            // FileExtension_TextBox
            // 
            this.FileExtension_TextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.FileExtension_TextBox.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FileExtension_TextBox.Location = new System.Drawing.Point(440, 104);
            this.FileExtension_TextBox.Name = "FileExtension_TextBox";
            this.FileExtension_TextBox.Size = new System.Drawing.Size(116, 23);
            this.FileExtension_TextBox.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(14, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(212, 15);
            this.label8.TabIndex = 16;
            this.label8.Text = "Choose the application configurations:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(342, 136);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 15);
            this.label9.TabIndex = 17;
            this.label9.Text = "XPath Delimiter:";
            // 
            // Delimiter_TextBox
            // 
            this.Delimiter_TextBox.Location = new System.Drawing.Point(440, 133);
            this.Delimiter_TextBox.Name = "Delimiter_TextBox";
            this.Delimiter_TextBox.Size = new System.Drawing.Size(116, 23);
            this.Delimiter_TextBox.TabIndex = 7;
            // 
            // AppConfigForm
            // 
            this.AcceptButton = this.AppConfigOk_Button;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.CancelButton = this.AppConfigCancel_Button;
            this.ClientSize = new System.Drawing.Size(562, 205);
            this.ControlBox = false;
            this.Controls.Add(this.Delimiter_TextBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.FileExtension_TextBox);
            this.Controls.Add(this.DiffFileName_TextBox);
            this.Controls.Add(this.SummaryFileToken_TextBox);
            this.Controls.Add(this.MasterFileToken_TextBox);
            this.Controls.Add(this.DiffFilesToken_TextBox);
            this.Controls.Add(this.ReferenceFilesToken_TextBox);
            this.Controls.Add(this.NewFilesToken_TextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AppConfigCancel_Button);
            this.Controls.Add(this.AppConfigOk_Button);
            this.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AppConfigForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AppConfigForm";
            this.Load += new System.EventHandler(this.AppConfigForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AppConfigOk_Button;
        private System.Windows.Forms.Button AppConfigCancel_Button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox NewFilesToken_TextBox;
        private System.Windows.Forms.TextBox ReferenceFilesToken_TextBox;
        private System.Windows.Forms.TextBox DiffFilesToken_TextBox;
        private System.Windows.Forms.TextBox MasterFileToken_TextBox;
        private System.Windows.Forms.TextBox SummaryFileToken_TextBox;
        private System.Windows.Forms.TextBox DiffFileName_TextBox;
        private System.Windows.Forms.TextBox FileExtension_TextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Delimiter_TextBox;
    }
}