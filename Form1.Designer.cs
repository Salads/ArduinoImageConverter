namespace ArduinoImageConverter
{
    partial class Form1
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
            this.m_guiFileListView = new System.Windows.Forms.ListView();
            this.m_guiFilesGroup = new System.Windows.Forms.GroupBox();
            this.m_guiAddFilesButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.m_guiArrayElemSizeComboBox = new System.Windows.Forms.ComboBox();
            this.m_guiSwapRBCheckbox = new System.Windows.Forms.CheckBox();
            this.m_guiUseStdIntCheckbox = new System.Windows.Forms.CheckBox();
            this.m_guiConvertButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.m_guiFormatComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.m_guiCodeTextBox = new System.Windows.Forms.TextBox();
            this.m_guiFilesGroup.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // m_guiFileListView
            // 
            this.m_guiFileListView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.m_guiFileListView.HideSelection = false;
            this.m_guiFileListView.Location = new System.Drawing.Point(6, 19);
            this.m_guiFileListView.MultiSelect = false;
            this.m_guiFileListView.Name = "m_guiFileListView";
            this.m_guiFileListView.Size = new System.Drawing.Size(410, 250);
            this.m_guiFileListView.TabIndex = 0;
            this.m_guiFileListView.UseCompatibleStateImageBehavior = false;
            this.m_guiFileListView.View = System.Windows.Forms.View.List;
            // 
            // m_guiFilesGroup
            // 
            this.m_guiFilesGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.m_guiFilesGroup.Controls.Add(this.m_guiFileListView);
            this.m_guiFilesGroup.Location = new System.Drawing.Point(12, 42);
            this.m_guiFilesGroup.Name = "m_guiFilesGroup";
            this.m_guiFilesGroup.Size = new System.Drawing.Size(422, 276);
            this.m_guiFilesGroup.TabIndex = 1;
            this.m_guiFilesGroup.TabStop = false;
            this.m_guiFilesGroup.Text = "Files";
            this.m_guiFilesGroup.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // m_guiAddFilesButton
            // 
            this.m_guiAddFilesButton.Location = new System.Drawing.Point(12, 13);
            this.m_guiAddFilesButton.Name = "m_guiAddFilesButton";
            this.m_guiAddFilesButton.Size = new System.Drawing.Size(75, 23);
            this.m_guiAddFilesButton.TabIndex = 1;
            this.m_guiAddFilesButton.Text = "Select Files";
            this.m_guiAddFilesButton.UseVisualStyleBackColor = true;
            this.m_guiAddFilesButton.Click += new System.EventHandler(this.selectFilesButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.m_guiArrayElemSizeComboBox);
            this.groupBox1.Controls.Add(this.m_guiSwapRBCheckbox);
            this.groupBox1.Controls.Add(this.m_guiUseStdIntCheckbox);
            this.groupBox1.Controls.Add(this.m_guiConvertButton);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.m_guiFormatComboBox);
            this.groupBox1.Location = new System.Drawing.Point(13, 324);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(421, 148);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Format";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Code Array Size:";
            // 
            // m_guiArrayElemSizeComboBox
            // 
            this.m_guiArrayElemSizeComboBox.FormattingEnabled = true;
            this.m_guiArrayElemSizeComboBox.Items.AddRange(new object[] {
            "8 bit",
            "16 bit",
            "32 bit"});
            this.m_guiArrayElemSizeComboBox.Location = new System.Drawing.Point(98, 45);
            this.m_guiArrayElemSizeComboBox.Name = "m_guiArrayElemSizeComboBox";
            this.m_guiArrayElemSizeComboBox.Size = new System.Drawing.Size(121, 21);
            this.m_guiArrayElemSizeComboBox.TabIndex = 5;
            // 
            // m_guiSwapRBCheckbox
            // 
            this.m_guiSwapRBCheckbox.AutoSize = true;
            this.m_guiSwapRBCheckbox.Location = new System.Drawing.Point(10, 95);
            this.m_guiSwapRBCheckbox.Name = "m_guiSwapRBCheckbox";
            this.m_guiSwapRBCheckbox.Size = new System.Drawing.Size(71, 17);
            this.m_guiSwapRBCheckbox.TabIndex = 4;
            this.m_guiSwapRBCheckbox.Text = "Swap RB";
            this.m_guiSwapRBCheckbox.UseVisualStyleBackColor = true;
            // 
            // m_guiUseStdIntCheckbox
            // 
            this.m_guiUseStdIntCheckbox.AutoSize = true;
            this.m_guiUseStdIntCheckbox.Location = new System.Drawing.Point(10, 72);
            this.m_guiUseStdIntCheckbox.Name = "m_guiUseStdIntCheckbox";
            this.m_guiUseStdIntCheckbox.Size = new System.Drawing.Size(135, 17);
            this.m_guiUseStdIntCheckbox.TabIndex = 3;
            this.m_guiUseStdIntCheckbox.Text = "Use stdint (uint8_t, etc)";
            this.m_guiUseStdIntCheckbox.UseVisualStyleBackColor = true;
            // 
            // m_guiConvertButton
            // 
            this.m_guiConvertButton.Location = new System.Drawing.Point(5, 118);
            this.m_guiConvertButton.Name = "m_guiConvertButton";
            this.m_guiConvertButton.Size = new System.Drawing.Size(75, 23);
            this.m_guiConvertButton.TabIndex = 2;
            this.m_guiConvertButton.Text = "Convert";
            this.m_guiConvertButton.UseVisualStyleBackColor = true;
            this.m_guiConvertButton.Click += new System.EventHandler(this.m_guiConvertButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Desired Format:";
            // 
            // m_guiFormatComboBox
            // 
            this.m_guiFormatComboBox.FormattingEnabled = true;
            this.m_guiFormatComboBox.Items.AddRange(new object[] {
            "1 bpp (monochrome)",
            "16 bpp (5,6,5)",
            "24 bpp (6,6,6)"});
            this.m_guiFormatComboBox.Location = new System.Drawing.Point(98, 17);
            this.m_guiFormatComboBox.Name = "m_guiFormatComboBox";
            this.m_guiFormatComboBox.Size = new System.Drawing.Size(121, 21);
            this.m_guiFormatComboBox.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.m_guiCodeTextBox);
            this.groupBox2.Location = new System.Drawing.Point(441, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(347, 459);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Arduino Code";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(266, 430);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Copy Code";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.OnCopyCodeButton_Click);
            // 
            // m_guiCodeTextBox
            // 
            this.m_guiCodeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.m_guiCodeTextBox.Location = new System.Drawing.Point(7, 18);
            this.m_guiCodeTextBox.MaxLength = 2147483647;
            this.m_guiCodeTextBox.Multiline = true;
            this.m_guiCodeTextBox.Name = "m_guiCodeTextBox";
            this.m_guiCodeTextBox.ReadOnly = true;
            this.m_guiCodeTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.m_guiCodeTextBox.Size = new System.Drawing.Size(334, 406);
            this.m_guiCodeTextBox.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 480);
            this.Controls.Add(this.m_guiAddFilesButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.m_guiFilesGroup);
            this.MinimumSize = new System.Drawing.Size(816, 416);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.m_guiFilesGroup.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView m_guiFileListView;
        private System.Windows.Forms.GroupBox m_guiFilesGroup;
        private System.Windows.Forms.Button m_guiAddFilesButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox m_guiFormatComboBox;
        private System.Windows.Forms.Button m_guiConvertButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox m_guiCodeTextBox;
        private System.Windows.Forms.CheckBox m_guiUseStdIntCheckbox;
        private System.Windows.Forms.CheckBox m_guiSwapRBCheckbox;
        private System.Windows.Forms.ComboBox m_guiArrayElemSizeComboBox;
        private System.Windows.Forms.Label label2;
    }
}

