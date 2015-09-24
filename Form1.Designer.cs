namespace WavToMP3
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
            this.buttonSelectDirectory = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.checkBoxDeleteSourceFiles = new System.Windows.Forms.CheckBox();
            this.textBoxProgress = new System.Windows.Forms.TextBox();
            this.comboBoxBitRate = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxArtistName = new System.Windows.Forms.TextBox();
            this.labelArtistName = new System.Windows.Forms.Label();
            this.labelAlbumName = new System.Windows.Forms.Label();
            this.textBoxAlbumName = new System.Windows.Forms.TextBox();
            this.checkBoxID3Tags = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // buttonSelectDirectory
            // 
            this.buttonSelectDirectory.Location = new System.Drawing.Point(60, 12);
            this.buttonSelectDirectory.Name = "buttonSelectDirectory";
            this.buttonSelectDirectory.Size = new System.Drawing.Size(161, 23);
            this.buttonSelectDirectory.TabIndex = 0;
            this.buttonSelectDirectory.Text = "Select Directory";
            this.buttonSelectDirectory.UseVisualStyleBackColor = true;
            this.buttonSelectDirectory.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBoxDeleteSourceFiles
            // 
            this.checkBoxDeleteSourceFiles.AutoSize = true;
            this.checkBoxDeleteSourceFiles.Location = new System.Drawing.Point(60, 41);
            this.checkBoxDeleteSourceFiles.Name = "checkBoxDeleteSourceFiles";
            this.checkBoxDeleteSourceFiles.Size = new System.Drawing.Size(124, 17);
            this.checkBoxDeleteSourceFiles.TabIndex = 1;
            this.checkBoxDeleteSourceFiles.Text = "Delete Source File(s)";
            this.checkBoxDeleteSourceFiles.UseVisualStyleBackColor = true;
            // 
            // textBoxProgress
            // 
            this.textBoxProgress.Location = new System.Drawing.Point(60, 122);
            this.textBoxProgress.Multiline = true;
            this.textBoxProgress.Name = "textBoxProgress";
            this.textBoxProgress.ReadOnly = true;
            this.textBoxProgress.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxProgress.Size = new System.Drawing.Size(531, 362);
            this.textBoxProgress.TabIndex = 2;
            // 
            // comboBoxBitRate
            // 
            this.comboBoxBitRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBitRate.FormattingEnabled = true;
            this.comboBoxBitRate.Items.AddRange(new object[] {
            "128",
            "320"});
            this.comboBoxBitRate.Location = new System.Drawing.Point(337, 12);
            this.comboBoxBitRate.Name = "comboBoxBitRate";
            this.comboBoxBitRate.Size = new System.Drawing.Size(121, 21);
            this.comboBoxBitRate.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(286, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Bit Rate";
            // 
            // textBoxArtistName
            // 
            this.textBoxArtistName.Location = new System.Drawing.Point(144, 70);
            this.textBoxArtistName.Name = "textBoxArtistName";
            this.textBoxArtistName.Size = new System.Drawing.Size(187, 20);
            this.textBoxArtistName.TabIndex = 5;
            // 
            // labelArtistName
            // 
            this.labelArtistName.AutoSize = true;
            this.labelArtistName.Location = new System.Drawing.Point(60, 73);
            this.labelArtistName.Name = "labelArtistName";
            this.labelArtistName.Size = new System.Drawing.Size(61, 13);
            this.labelArtistName.TabIndex = 6;
            this.labelArtistName.Text = "Artist Name";
            // 
            // labelAlbumName
            // 
            this.labelAlbumName.AutoSize = true;
            this.labelAlbumName.Location = new System.Drawing.Point(60, 99);
            this.labelAlbumName.Name = "labelAlbumName";
            this.labelAlbumName.Size = new System.Drawing.Size(67, 13);
            this.labelAlbumName.TabIndex = 8;
            this.labelAlbumName.Text = "Album Name";
            // 
            // textBoxAlbumName
            // 
            this.textBoxAlbumName.Location = new System.Drawing.Point(144, 96);
            this.textBoxAlbumName.Name = "textBoxAlbumName";
            this.textBoxAlbumName.Size = new System.Drawing.Size(187, 20);
            this.textBoxAlbumName.TabIndex = 7;
            // 
            // checkBoxID3Tags
            // 
            this.checkBoxID3Tags.AutoSize = true;
            this.checkBoxID3Tags.Location = new System.Drawing.Point(289, 41);
            this.checkBoxID3Tags.Name = "checkBoxID3Tags";
            this.checkBoxID3Tags.Size = new System.Drawing.Size(89, 17);
            this.checkBoxID3Tags.TabIndex = 9;
            this.checkBoxID3Tags.Text = "Set ID3 Tags";
            this.checkBoxID3Tags.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 510);
            this.Controls.Add(this.checkBoxID3Tags);
            this.Controls.Add(this.labelAlbumName);
            this.Controls.Add(this.textBoxAlbumName);
            this.Controls.Add(this.labelArtistName);
            this.Controls.Add(this.textBoxArtistName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxBitRate);
            this.Controls.Add(this.textBoxProgress);
            this.Controls.Add(this.checkBoxDeleteSourceFiles);
            this.Controls.Add(this.buttonSelectDirectory);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Convert WAV to MP3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSelectDirectory;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.CheckBox checkBoxDeleteSourceFiles;
        private System.Windows.Forms.TextBox textBoxProgress;
        private System.Windows.Forms.ComboBox comboBoxBitRate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxArtistName;
        private System.Windows.Forms.Label labelArtistName;
        private System.Windows.Forms.Label labelAlbumName;
        private System.Windows.Forms.TextBox textBoxAlbumName;
        private System.Windows.Forms.CheckBox checkBoxID3Tags;
    }
}

