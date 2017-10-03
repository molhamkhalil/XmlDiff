namespace VisualXmlDiff
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.XmlDiff_GroupBox = new System.Windows.Forms.GroupBox();
            this.DiffOptions_Button = new System.Windows.Forms.Button();
            this.AppConfig_Button = new System.Windows.Forms.Button();
            this.XPath_TextBox = new System.Windows.Forms.RichTextBox();
            this.ExcludeNodes_CheckBox = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Open_Button = new System.Windows.Forms.Button();
            this.DateTime_Label = new System.Windows.Forms.Label();
            this.XmlDiffFolder_Button = new System.Windows.Forms.Button();
            this.ReferenceFolder_Button = new System.Windows.Forms.Button();
            this.NewFolder_Button = new System.Windows.Forms.Button();
            this.Browse_Button = new System.Windows.Forms.Button();
            this.Save_Button = new System.Windows.Forms.Button();
            this.Compare_Button = new System.Windows.Forms.Button();
            this.XmlDiffFolder_TextBox = new System.Windows.Forms.TextBox();
            this.ReferenceFolder_TextBox = new System.Windows.Forms.TextBox();
            this.NewFolder_TextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.XmlDiff_GroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // XmlDiff_GroupBox
            // 
            this.XmlDiff_GroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.XmlDiff_GroupBox.Controls.Add(this.DiffOptions_Button);
            this.XmlDiff_GroupBox.Controls.Add(this.AppConfig_Button);
            this.XmlDiff_GroupBox.Controls.Add(this.XPath_TextBox);
            this.XmlDiff_GroupBox.Controls.Add(this.ExcludeNodes_CheckBox);
            this.XmlDiff_GroupBox.Controls.Add(this.label4);
            this.XmlDiff_GroupBox.Controls.Add(this.Open_Button);
            this.XmlDiff_GroupBox.Controls.Add(this.DateTime_Label);
            this.XmlDiff_GroupBox.Controls.Add(this.XmlDiffFolder_Button);
            this.XmlDiff_GroupBox.Controls.Add(this.ReferenceFolder_Button);
            this.XmlDiff_GroupBox.Controls.Add(this.NewFolder_Button);
            this.XmlDiff_GroupBox.Controls.Add(this.Browse_Button);
            this.XmlDiff_GroupBox.Controls.Add(this.Save_Button);
            this.XmlDiff_GroupBox.Controls.Add(this.Compare_Button);
            this.XmlDiff_GroupBox.Controls.Add(this.XmlDiffFolder_TextBox);
            this.XmlDiff_GroupBox.Controls.Add(this.ReferenceFolder_TextBox);
            this.XmlDiff_GroupBox.Controls.Add(this.NewFolder_TextBox);
            this.XmlDiff_GroupBox.Controls.Add(this.label3);
            this.XmlDiff_GroupBox.Controls.Add(this.label2);
            this.XmlDiff_GroupBox.Controls.Add(this.label1);
            this.XmlDiff_GroupBox.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XmlDiff_GroupBox.Location = new System.Drawing.Point(12, 12);
            this.XmlDiff_GroupBox.Name = "XmlDiff_GroupBox";
            this.XmlDiff_GroupBox.Size = new System.Drawing.Size(540, 315);
            this.XmlDiff_GroupBox.TabIndex = 0;
            this.XmlDiff_GroupBox.TabStop = false;
            this.XmlDiff_GroupBox.Text = "Xml Diff";
            // 
            // DiffOptions_Button
            // 
            this.DiffOptions_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.DiffOptions_Button.Image = ((System.Drawing.Image)(resources.GetObject("DiffOptions_Button.Image")));
            this.DiffOptions_Button.Location = new System.Drawing.Point(115, 257);
            this.DiffOptions_Button.Name = "DiffOptions_Button";
            this.DiffOptions_Button.Size = new System.Drawing.Size(53, 43);
            this.DiffOptions_Button.TabIndex = 10;
            this.DiffOptions_Button.UseVisualStyleBackColor = true;
            this.DiffOptions_Button.Click += new System.EventHandler(this.DiffOptions_Button_Click);
            // 
            // AppConfig_Button
            // 
            this.AppConfig_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AppConfig_Button.Image = ((System.Drawing.Image)(resources.GetObject("AppConfig_Button.Image")));
            this.AppConfig_Button.Location = new System.Drawing.Point(174, 257);
            this.AppConfig_Button.Name = "AppConfig_Button";
            this.AppConfig_Button.Size = new System.Drawing.Size(53, 43);
            this.AppConfig_Button.TabIndex = 11;
            this.AppConfig_Button.UseVisualStyleBackColor = true;
            this.AppConfig_Button.Click += new System.EventHandler(this.AppConfig_Button_Click);
            // 
            // XPath_TextBox
            // 
            this.XPath_TextBox.AcceptsTab = true;
            this.XPath_TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.XPath_TextBox.AutoWordSelection = true;
            this.XPath_TextBox.EnableAutoDragDrop = true;
            this.XPath_TextBox.Location = new System.Drawing.Point(121, 130);
            this.XPath_TextBox.Name = "XPath_TextBox";
            this.XPath_TextBox.Size = new System.Drawing.Size(311, 82);
            this.XPath_TextBox.TabIndex = 9;
            this.XPath_TextBox.Text = "";
            // 
            // ExcludeNodes_CheckBox
            // 
            this.ExcludeNodes_CheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ExcludeNodes_CheckBox.AutoSize = true;
            this.ExcludeNodes_CheckBox.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExcludeNodes_CheckBox.Location = new System.Drawing.Point(438, 160);
            this.ExcludeNodes_CheckBox.Name = "ExcludeNodes_CheckBox";
            this.ExcludeNodes_CheckBox.Size = new System.Drawing.Size(66, 19);
            this.ExcludeNodes_CheckBox.TabIndex = 8;
            this.ExcludeNodes_CheckBox.Text = "Exclude";
            this.ExcludeNodes_CheckBox.UseVisualStyleBackColor = true;
            this.ExcludeNodes_CheckBox.CheckedChanged += new System.EventHandler(this.XPath_CheckBox_CheckedChanged);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(71, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 15);
            this.label4.TabIndex = 14;
            this.label4.Text = "Nodes:";
            // 
            // Open_Button
            // 
            this.Open_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Open_Button.Image = ((System.Drawing.Image)(resources.GetObject("Open_Button.Image")));
            this.Open_Button.Location = new System.Drawing.Point(326, 257);
            this.Open_Button.Name = "Open_Button";
            this.Open_Button.Size = new System.Drawing.Size(50, 43);
            this.Open_Button.TabIndex = 12;
            this.Open_Button.UseVisualStyleBackColor = true;
            this.Open_Button.Click += new System.EventHandler(this.Open_Button_Click);
            // 
            // DateTime_Label
            // 
            this.DateTime_Label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.DateTime_Label.AutoSize = true;
            this.DateTime_Label.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateTime_Label.Location = new System.Drawing.Point(128, 226);
            this.DateTime_Label.Name = "DateTime_Label";
            this.DateTime_Label.Size = new System.Drawing.Size(0, 15);
            this.DateTime_Label.TabIndex = 12;
            // 
            // XmlDiffFolder_Button
            // 
            this.XmlDiffFolder_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.XmlDiffFolder_Button.Image = ((System.Drawing.Image)(resources.GetObject("XmlDiffFolder_Button.Image")));
            this.XmlDiffFolder_Button.Location = new System.Drawing.Point(438, 90);
            this.XmlDiffFolder_Button.Name = "XmlDiffFolder_Button";
            this.XmlDiffFolder_Button.Size = new System.Drawing.Size(27, 20);
            this.XmlDiffFolder_Button.TabIndex = 5;
            this.XmlDiffFolder_Button.UseVisualStyleBackColor = true;
            this.XmlDiffFolder_Button.Click += new System.EventHandler(this.XmlDiffFolder_Button_Click);
            // 
            // ReferenceFolder_Button
            // 
            this.ReferenceFolder_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ReferenceFolder_Button.Image = ((System.Drawing.Image)(resources.GetObject("ReferenceFolder_Button.Image")));
            this.ReferenceFolder_Button.Location = new System.Drawing.Point(438, 60);
            this.ReferenceFolder_Button.Name = "ReferenceFolder_Button";
            this.ReferenceFolder_Button.Size = new System.Drawing.Size(27, 20);
            this.ReferenceFolder_Button.TabIndex = 3;
            this.ReferenceFolder_Button.UseVisualStyleBackColor = true;
            this.ReferenceFolder_Button.Click += new System.EventHandler(this.ReferenceFolder_Button_Click);
            // 
            // NewFolder_Button
            // 
            this.NewFolder_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.NewFolder_Button.Image = ((System.Drawing.Image)(resources.GetObject("NewFolder_Button.Image")));
            this.NewFolder_Button.Location = new System.Drawing.Point(438, 31);
            this.NewFolder_Button.Name = "NewFolder_Button";
            this.NewFolder_Button.Size = new System.Drawing.Size(27, 20);
            this.NewFolder_Button.TabIndex = 1;
            this.NewFolder_Button.UseVisualStyleBackColor = true;
            this.NewFolder_Button.Click += new System.EventHandler(this.NewFolder_Button_Click);
            // 
            // Browse_Button
            // 
            this.Browse_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Browse_Button.Image = ((System.Drawing.Image)(resources.GetObject("Browse_Button.Image")));
            this.Browse_Button.Location = new System.Drawing.Point(471, 31);
            this.Browse_Button.Name = "Browse_Button";
            this.Browse_Button.Size = new System.Drawing.Size(50, 38);
            this.Browse_Button.TabIndex = 6;
            this.Browse_Button.UseVisualStyleBackColor = true;
            this.Browse_Button.Click += new System.EventHandler(this.Brwose_Button_Click);
            // 
            // Save_Button
            // 
            this.Save_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Save_Button.Image = ((System.Drawing.Image)(resources.GetObject("Save_Button.Image")));
            this.Save_Button.Location = new System.Drawing.Point(471, 72);
            this.Save_Button.Name = "Save_Button";
            this.Save_Button.Size = new System.Drawing.Size(50, 38);
            this.Save_Button.TabIndex = 7;
            this.Save_Button.UseVisualStyleBackColor = true;
            this.Save_Button.Click += new System.EventHandler(this.Save_Button_Click);
            // 
            // Compare_Button
            // 
            this.Compare_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Compare_Button.Image = global::VisualXmlDiff.Properties.Resources.StatusAnnotations_Play_32xLG_color;
            this.Compare_Button.Location = new System.Drawing.Point(382, 257);
            this.Compare_Button.Name = "Compare_Button";
            this.Compare_Button.Size = new System.Drawing.Size(50, 43);
            this.Compare_Button.TabIndex = 13;
            this.Compare_Button.UseVisualStyleBackColor = true;
            this.Compare_Button.Click += new System.EventHandler(this.Compare_Button_Click);
            // 
            // XmlDiffFolder_TextBox
            // 
            this.XmlDiffFolder_TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.XmlDiffFolder_TextBox.Location = new System.Drawing.Point(121, 91);
            this.XmlDiffFolder_TextBox.Name = "XmlDiffFolder_TextBox";
            this.XmlDiffFolder_TextBox.Size = new System.Drawing.Size(311, 23);
            this.XmlDiffFolder_TextBox.TabIndex = 4;
            this.XmlDiffFolder_TextBox.TextChanged += new System.EventHandler(this.XmlDiffFolder_TextBox_TextChanged);
            // 
            // ReferenceFolder_TextBox
            // 
            this.ReferenceFolder_TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ReferenceFolder_TextBox.Location = new System.Drawing.Point(121, 60);
            this.ReferenceFolder_TextBox.Name = "ReferenceFolder_TextBox";
            this.ReferenceFolder_TextBox.Size = new System.Drawing.Size(311, 23);
            this.ReferenceFolder_TextBox.TabIndex = 2;
            this.ReferenceFolder_TextBox.TextChanged += new System.EventHandler(this.ReferenceFolder_TextBox_TextChanged);
            // 
            // NewFolder_TextBox
            // 
            this.NewFolder_TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.NewFolder_TextBox.Location = new System.Drawing.Point(121, 31);
            this.NewFolder_TextBox.Name = "NewFolder_TextBox";
            this.NewFolder_TextBox.Size = new System.Drawing.Size(311, 23);
            this.NewFolder_TextBox.TabIndex = 0;
            this.NewFolder_TextBox.TextChanged += new System.EventHandler(this.NewFolder_TextBox_TextChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(50, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Diff Folder:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Reference Folder:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "New Folder:";
            // 
            // MainForm
            // 
            this.AcceptButton = this.Compare_Button;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(564, 335);
            this.Controls.Add(this.XmlDiff_GroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "XML Diff";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.XmlDiff_GroupBox.ResumeLayout(false);
            this.XmlDiff_GroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox XmlDiff_GroupBox;
        private System.Windows.Forms.Button XmlDiffFolder_Button;
        private System.Windows.Forms.Button ReferenceFolder_Button;
        private System.Windows.Forms.Button NewFolder_Button;
        private System.Windows.Forms.Button Browse_Button;
        private System.Windows.Forms.Button Save_Button;
        private System.Windows.Forms.Button Compare_Button;
        private System.Windows.Forms.TextBox XmlDiffFolder_TextBox;
        private System.Windows.Forms.TextBox ReferenceFolder_TextBox;
        private System.Windows.Forms.TextBox NewFolder_TextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label DateTime_Label;
        private System.Windows.Forms.Button Open_Button;
        private System.Windows.Forms.CheckBox ExcludeNodes_CheckBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button DiffOptions_Button;
        private System.Windows.Forms.Button AppConfig_Button;
        private System.Windows.Forms.RichTextBox XPath_TextBox;
    }
}