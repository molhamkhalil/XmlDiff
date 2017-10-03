namespace VisualXmlDiff.Forms
{
    partial class DiffOptionsForm
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
            this.None_CheckBox = new System.Windows.Forms.CheckBox();
            this.ChildOrder_CheckBox = new System.Windows.Forms.CheckBox();
            this.Comments_CheckBox = new System.Windows.Forms.CheckBox();
            this.Dtd_CheckBox = new System.Windows.Forms.CheckBox();
            this.Namespaces_CheckBox = new System.Windows.Forms.CheckBox();
            this.Pi_CheckBox = new System.Windows.Forms.CheckBox();
            this.Prefixes_CheckBox = new System.Windows.Forms.CheckBox();
            this.Whitespace_CheckBox = new System.Windows.Forms.CheckBox();
            this.XmlDecleration_CheckBox = new System.Windows.Forms.CheckBox();
            this.DiffOptionsCancel_Button = new System.Windows.Forms.Button();
            this.DiffOptionsOk_Button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // None_CheckBox
            // 
            this.None_CheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.None_CheckBox.AutoSize = true;
            this.None_CheckBox.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.None_CheckBox.Location = new System.Drawing.Point(26, 53);
            this.None_CheckBox.Name = "None_CheckBox";
            this.None_CheckBox.Size = new System.Drawing.Size(55, 19);
            this.None_CheckBox.TabIndex = 0;
            this.None_CheckBox.Text = "None";
            this.None_CheckBox.UseVisualStyleBackColor = true;
            this.None_CheckBox.CheckedChanged += new System.EventHandler(this.None_CheckBox_CheckedChanged);
            // 
            // ChildOrder_CheckBox
            // 
            this.ChildOrder_CheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ChildOrder_CheckBox.AutoSize = true;
            this.ChildOrder_CheckBox.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChildOrder_CheckBox.Location = new System.Drawing.Point(205, 53);
            this.ChildOrder_CheckBox.Name = "ChildOrder_CheckBox";
            this.ChildOrder_CheckBox.Size = new System.Drawing.Size(124, 19);
            this.ChildOrder_CheckBox.TabIndex = 1;
            this.ChildOrder_CheckBox.Text = "Ignore Child Order";
            this.ChildOrder_CheckBox.UseVisualStyleBackColor = true;
            this.ChildOrder_CheckBox.CheckedChanged += new System.EventHandler(this.ChildOrder_CheckBox_CheckedChanged);
            // 
            // Comments_CheckBox
            // 
            this.Comments_CheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Comments_CheckBox.AutoSize = true;
            this.Comments_CheckBox.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Comments_CheckBox.Location = new System.Drawing.Point(26, 78);
            this.Comments_CheckBox.Name = "Comments_CheckBox";
            this.Comments_CheckBox.Size = new System.Drawing.Size(122, 19);
            this.Comments_CheckBox.TabIndex = 2;
            this.Comments_CheckBox.Text = "Ignore Comments";
            this.Comments_CheckBox.UseVisualStyleBackColor = true;
            this.Comments_CheckBox.CheckedChanged += new System.EventHandler(this.Comments_CheckBox_CheckedChanged);
            // 
            // Dtd_CheckBox
            // 
            this.Dtd_CheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Dtd_CheckBox.AutoSize = true;
            this.Dtd_CheckBox.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dtd_CheckBox.Location = new System.Drawing.Point(205, 78);
            this.Dtd_CheckBox.Name = "Dtd_CheckBox";
            this.Dtd_CheckBox.Size = new System.Drawing.Size(82, 19);
            this.Dtd_CheckBox.TabIndex = 3;
            this.Dtd_CheckBox.Text = "Ignore Dtd";
            this.Dtd_CheckBox.UseVisualStyleBackColor = true;
            this.Dtd_CheckBox.CheckedChanged += new System.EventHandler(this.Dtd_CheckBox_CheckedChanged);
            // 
            // Namespaces_CheckBox
            // 
            this.Namespaces_CheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Namespaces_CheckBox.AutoSize = true;
            this.Namespaces_CheckBox.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Namespaces_CheckBox.Location = new System.Drawing.Point(26, 103);
            this.Namespaces_CheckBox.Name = "Namespaces_CheckBox";
            this.Namespaces_CheckBox.Size = new System.Drawing.Size(130, 19);
            this.Namespaces_CheckBox.TabIndex = 4;
            this.Namespaces_CheckBox.Text = "Ignore Namespaces";
            this.Namespaces_CheckBox.UseVisualStyleBackColor = true;
            this.Namespaces_CheckBox.CheckedChanged += new System.EventHandler(this.Namespaces_CheckBox_CheckedChanged);
            // 
            // Pi_CheckBox
            // 
            this.Pi_CheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Pi_CheckBox.AutoSize = true;
            this.Pi_CheckBox.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pi_CheckBox.Location = new System.Drawing.Point(205, 103);
            this.Pi_CheckBox.Name = "Pi_CheckBox";
            this.Pi_CheckBox.Size = new System.Drawing.Size(73, 19);
            this.Pi_CheckBox.TabIndex = 5;
            this.Pi_CheckBox.Text = "Ignore PI";
            this.Pi_CheckBox.UseVisualStyleBackColor = true;
            this.Pi_CheckBox.CheckedChanged += new System.EventHandler(this.Pi_CheckBox_CheckedChanged);
            // 
            // Prefixes_CheckBox
            // 
            this.Prefixes_CheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Prefixes_CheckBox.AutoSize = true;
            this.Prefixes_CheckBox.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Prefixes_CheckBox.Location = new System.Drawing.Point(26, 128);
            this.Prefixes_CheckBox.Name = "Prefixes_CheckBox";
            this.Prefixes_CheckBox.Size = new System.Drawing.Size(103, 19);
            this.Prefixes_CheckBox.TabIndex = 6;
            this.Prefixes_CheckBox.Text = "Ignore Prefixes";
            this.Prefixes_CheckBox.UseVisualStyleBackColor = true;
            this.Prefixes_CheckBox.CheckedChanged += new System.EventHandler(this.Prefixes_CheckBox_CheckedChanged);
            // 
            // Whitespace_CheckBox
            // 
            this.Whitespace_CheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Whitespace_CheckBox.AutoSize = true;
            this.Whitespace_CheckBox.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Whitespace_CheckBox.Location = new System.Drawing.Point(205, 128);
            this.Whitespace_CheckBox.Name = "Whitespace_CheckBox";
            this.Whitespace_CheckBox.Size = new System.Drawing.Size(124, 19);
            this.Whitespace_CheckBox.TabIndex = 7;
            this.Whitespace_CheckBox.Text = "Ignore Whitespace";
            this.Whitespace_CheckBox.UseVisualStyleBackColor = true;
            this.Whitespace_CheckBox.CheckedChanged += new System.EventHandler(this.Whitespace_CheckBox_CheckedChanged);
            // 
            // XmlDecleration_CheckBox
            // 
            this.XmlDecleration_CheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.XmlDecleration_CheckBox.AutoSize = true;
            this.XmlDecleration_CheckBox.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XmlDecleration_CheckBox.Location = new System.Drawing.Point(25, 153);
            this.XmlDecleration_CheckBox.Name = "XmlDecleration_CheckBox";
            this.XmlDecleration_CheckBox.Size = new System.Drawing.Size(147, 19);
            this.XmlDecleration_CheckBox.TabIndex = 8;
            this.XmlDecleration_CheckBox.Text = "Ignore Xml Decleration";
            this.XmlDecleration_CheckBox.UseVisualStyleBackColor = true;
            this.XmlDecleration_CheckBox.CheckedChanged += new System.EventHandler(this.XmlDecleration_CheckBox_CheckedChanged);
            // 
            // DiffOptionsCancel_Button
            // 
            this.DiffOptionsCancel_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DiffOptionsCancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.DiffOptionsCancel_Button.Location = new System.Drawing.Point(264, 178);
            this.DiffOptionsCancel_Button.Name = "DiffOptionsCancel_Button";
            this.DiffOptionsCancel_Button.Size = new System.Drawing.Size(75, 23);
            this.DiffOptionsCancel_Button.TabIndex = 10;
            this.DiffOptionsCancel_Button.Text = "Cancel";
            this.DiffOptionsCancel_Button.UseVisualStyleBackColor = true;
            this.DiffOptionsCancel_Button.Click += new System.EventHandler(this.DiffOptionsCancel_Button_Click);
            // 
            // DiffOptionsOk_Button
            // 
            this.DiffOptionsOk_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DiffOptionsOk_Button.Location = new System.Drawing.Point(183, 178);
            this.DiffOptionsOk_Button.Name = "DiffOptionsOk_Button";
            this.DiffOptionsOk_Button.Size = new System.Drawing.Size(75, 23);
            this.DiffOptionsOk_Button.TabIndex = 9;
            this.DiffOptionsOk_Button.Text = "Ok";
            this.DiffOptionsOk_Button.UseVisualStyleBackColor = true;
            this.DiffOptionsOk_Button.Click += new System.EventHandler(this.DiffOptionsOk_Button_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "Choose Xml Diff Options:";
            // 
            // DiffOptionsForm
            // 
            this.AcceptButton = this.DiffOptionsOk_Button;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.CancelButton = this.DiffOptionsCancel_Button;
            this.ClientSize = new System.Drawing.Size(344, 206);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DiffOptionsOk_Button);
            this.Controls.Add(this.DiffOptionsCancel_Button);
            this.Controls.Add(this.XmlDecleration_CheckBox);
            this.Controls.Add(this.Whitespace_CheckBox);
            this.Controls.Add(this.Prefixes_CheckBox);
            this.Controls.Add(this.Pi_CheckBox);
            this.Controls.Add(this.Namespaces_CheckBox);
            this.Controls.Add(this.Dtd_CheckBox);
            this.Controls.Add(this.Comments_CheckBox);
            this.Controls.Add(this.ChildOrder_CheckBox);
            this.Controls.Add(this.None_CheckBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DiffOptionsForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Diff Options";
            this.Load += new System.EventHandler(this.DiffOptionsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox None_CheckBox;
        private System.Windows.Forms.CheckBox ChildOrder_CheckBox;
        private System.Windows.Forms.CheckBox Comments_CheckBox;
        private System.Windows.Forms.CheckBox Dtd_CheckBox;
        private System.Windows.Forms.CheckBox Namespaces_CheckBox;
        private System.Windows.Forms.CheckBox Pi_CheckBox;
        private System.Windows.Forms.CheckBox Prefixes_CheckBox;
        private System.Windows.Forms.CheckBox Whitespace_CheckBox;
        private System.Windows.Forms.CheckBox XmlDecleration_CheckBox;
        private System.Windows.Forms.Button DiffOptionsCancel_Button;
        private System.Windows.Forms.Button DiffOptionsOk_Button;
        private System.Windows.Forms.Label label1;
    }
}