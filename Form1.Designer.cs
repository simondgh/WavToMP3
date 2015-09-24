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
            this.groupBoxID3 = new System.Windows.Forms.GroupBox();
            this.checkBoxID3Tags = new System.Windows.Forms.CheckBox();
            this.labelAlbumName = new System.Windows.Forms.Label();
            this.textBoxAlbumName = new System.Windows.Forms.TextBox();
            this.labelArtistName = new System.Windows.Forms.Label();
            this.textBoxArtistName = new System.Windows.Forms.TextBox();
            this.labelGenre = new System.Windows.Forms.Label();
            this.listBoxGenre = new System.Windows.Forms.ListBox();
            this.groupBoxID3.SuspendLayout();
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
            this.textBoxProgress.Location = new System.Drawing.Point(60, 168);
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
            this.comboBoxBitRate.Location = new System.Drawing.Point(420, 14);
            this.comboBoxBitRate.Name = "comboBoxBitRate";
            this.comboBoxBitRate.Size = new System.Drawing.Size(121, 21);
            this.comboBoxBitRate.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(360, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Bit Rate";
            // 
            // groupBoxID3
            // 
            this.groupBoxID3.Controls.Add(this.listBoxGenre);
            this.groupBoxID3.Controls.Add(this.labelGenre);
            this.groupBoxID3.Controls.Add(this.checkBoxID3Tags);
            this.groupBoxID3.Controls.Add(this.labelAlbumName);
            this.groupBoxID3.Controls.Add(this.textBoxAlbumName);
            this.groupBoxID3.Controls.Add(this.labelArtistName);
            this.groupBoxID3.Controls.Add(this.textBoxArtistName);
            this.groupBoxID3.Location = new System.Drawing.Point(60, 64);
            this.groupBoxID3.Name = "groupBoxID3";
            this.groupBoxID3.Size = new System.Drawing.Size(531, 100);
            this.groupBoxID3.TabIndex = 10;
            this.groupBoxID3.TabStop = false;
            // 
            // checkBoxID3Tags
            // 
            this.checkBoxID3Tags.AutoSize = true;
            this.checkBoxID3Tags.Location = new System.Drawing.Point(6, 16);
            this.checkBoxID3Tags.Name = "checkBoxID3Tags";
            this.checkBoxID3Tags.Size = new System.Drawing.Size(89, 17);
            this.checkBoxID3Tags.TabIndex = 14;
            this.checkBoxID3Tags.Text = "Set ID3 Tags";
            this.checkBoxID3Tags.UseVisualStyleBackColor = true;
            this.checkBoxID3Tags.CheckedChanged += new System.EventHandler(this.checkBoxID3Tags_CheckedChanged);
            // 
            // labelAlbumName
            // 
            this.labelAlbumName.AutoSize = true;
            this.labelAlbumName.Location = new System.Drawing.Point(6, 65);
            this.labelAlbumName.Name = "labelAlbumName";
            this.labelAlbumName.Size = new System.Drawing.Size(67, 13);
            this.labelAlbumName.TabIndex = 13;
            this.labelAlbumName.Text = "Album Name";
            // 
            // textBoxAlbumName
            // 
            this.textBoxAlbumName.Enabled = false;
            this.textBoxAlbumName.Location = new System.Drawing.Point(84, 65);
            this.textBoxAlbumName.Name = "textBoxAlbumName";
            this.textBoxAlbumName.Size = new System.Drawing.Size(187, 20);
            this.textBoxAlbumName.TabIndex = 12;
            // 
            // labelArtistName
            // 
            this.labelArtistName.AutoSize = true;
            this.labelArtistName.Location = new System.Drawing.Point(6, 42);
            this.labelArtistName.Name = "labelArtistName";
            this.labelArtistName.Size = new System.Drawing.Size(61, 13);
            this.labelArtistName.TabIndex = 11;
            this.labelArtistName.Text = "Artist Name";
            // 
            // textBoxArtistName
            // 
            this.textBoxArtistName.Enabled = false;
            this.textBoxArtistName.Location = new System.Drawing.Point(84, 39);
            this.textBoxArtistName.Name = "textBoxArtistName";
            this.textBoxArtistName.Size = new System.Drawing.Size(187, 20);
            this.textBoxArtistName.TabIndex = 10;
            // 
            // labelGenre
            // 
            this.labelGenre.AutoSize = true;
            this.labelGenre.Location = new System.Drawing.Point(303, 41);
            this.labelGenre.Name = "labelGenre";
            this.labelGenre.Size = new System.Drawing.Size(36, 13);
            this.labelGenre.TabIndex = 16;
            this.labelGenre.Text = "Genre";
            // 
            // listBoxGenre
            // 
            this.listBoxGenre.Enabled = false;
            this.listBoxGenre.FormattingEnabled = true;
            this.listBoxGenre.Items.AddRange(new object[] {
            "0  - Blues",
            "1  - Classic Rock",
            "2  - Country",
            "3  - Dance",
            "4  - Disco",
            "5  - Funk",
            "6  - Grunge",
            "7  - Hip-Hop",
            "8  - Jazz",
            "9  - Metal",
            "10 - New Age",
            "11 - Oldies",
            "12 - Other",
            "13 - Pop",
            "14 - R&B",
            "15 - Rap",
            "16 - Reggae",
            "17 - Rock",
            "18 - Techno",
            "19 - Industrial",
            "20 - Alternative",
            "21 - Ska",
            "22 - Death Metal",
            "23 - Pranks",
            "24 - Soundtrack",
            "25 - Euro-Techno",
            "26 - Ambient",
            "27 - Trip-Hop",
            "28 - Vocal",
            "29 - Jazz+Funk",
            "30 - Fusion",
            "31 - Trance",
            "32 - Classical",
            "33 - Instrumental",
            "34 - Acid",
            "35 - House",
            "36 - Game",
            "37 - Sound Clip",
            "38 - Gospel",
            "39 - Noise",
            "40 - Alternative Rock",
            "41 - Bass",
            "42 - Soul",
            "43 - Punk",
            "44 - Space",
            "45 - Meditative",
            "46 - Instrumental Pop",
            "47 - Instrumental Rock",
            "48 - Ethnic",
            "49 - Gothic",
            "50 - Darkwave",
            "51 - Techno-Industrial",
            "52 - Electronic",
            "53 - Pop-Folk",
            "54 - Eurodance",
            "55 - Dream",
            "56 - Southern Rock",
            "57 - Comedy",
            "58 - Cult",
            "59 - Gangsta",
            "60 - Top 40",
            "61 - Christian Rap",
            "62 - Pop/Funk",
            "63 - Jungle",
            "64 - Native US",
            "65 - Cabaret",
            "66 - New Wave",
            "67 - Psychadelic",
            "68 - Rave",
            "69 - Showtunes",
            "70 - Trailer",
            "71 - Lo-Fi",
            "72 - Tribal",
            "73 - Acid Punk",
            "74 - Acid Jazz",
            "75 - Polka",
            "76 - Retro",
            "77 - Musical",
            "78 - Rock & Roll",
            "79 - Hard Rock",
            "80 - Folk",
            "81 - Folk-Rock",
            "82 - National Folk",
            "83 - Swing",
            "84 - Fast Fusion",
            "85 - Bebob",
            "86 - Latin",
            "87 - Revival",
            "88 - Celtic",
            "89 - Bluegrass",
            "90 - Avantgarde",
            "91 - Gothic Rock",
            "92 - Progressive Rock",
            "93 - Psychedelic Rock",
            "94 - Symphonic Rock",
            "95 - Slow Rock",
            "96 - Big Band",
            "97 - Chorus",
            "98 - Easy Listening",
            "99 - Acoustic",
            "100 - Humour",
            "101 - Speech",
            "102 - Chanson",
            "103 - Opera",
            "104 - Chamber Music",
            "105 - Sonata",
            "106 - Symphony",
            "107 - Booty Bass",
            "108 - Primus",
            "109 - Porn Groove",
            "110 - Satire",
            "111 - Slow Jam",
            "112 - Club",
            "113 - Tango",
            "114 - Samba",
            "115 - Folklore",
            "116 - Ballad",
            "117 - Power Ballad",
            "118 - Rhythmic Soul",
            "119 - Freestyle",
            "120 - Duet",
            "121 - Punk Rock",
            "122 - Drum Solo",
            "123 - Acapella",
            "124 - Euro-House",
            "125 - Dance Hall",
            "126 - Goa",
            "127 - Drum & Bass",
            "128 - Club - House",
            "129 - Hardcore",
            "130 - Terror",
            "131 - Indie",
            "132 - BritPop",
            "133 - Negerpunk",
            "134 - Polsk Punk",
            "135 - Beat",
            "136 - Christian Gangsta Rap",
            "137 - Heavy Metal",
            "138 - Black Metal",
            "139 - Crossover",
            "140 - Contemporary Christian",
            "141 - Christian Rock",
            "142 - Merengue",
            "143 - Salsa",
            "144 - Thrash Metal",
            "145 - Anime",
            "146 - JPop",
            "147 - Synthpop",
            "148  - Unknown"});
            this.listBoxGenre.Location = new System.Drawing.Point(345, 35);
            this.listBoxGenre.Name = "listBoxGenre";
            this.listBoxGenre.Size = new System.Drawing.Size(136, 56);
            this.listBoxGenre.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 542);
            this.Controls.Add(this.groupBoxID3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxBitRate);
            this.Controls.Add(this.textBoxProgress);
            this.Controls.Add(this.checkBoxDeleteSourceFiles);
            this.Controls.Add(this.buttonSelectDirectory);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Convert WAV to MP3";
            this.groupBoxID3.ResumeLayout(false);
            this.groupBoxID3.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBoxID3;
        private System.Windows.Forms.CheckBox checkBoxID3Tags;
        private System.Windows.Forms.Label labelAlbumName;
        private System.Windows.Forms.TextBox textBoxAlbumName;
        private System.Windows.Forms.Label labelArtistName;
        private System.Windows.Forms.TextBox textBoxArtistName;
        private System.Windows.Forms.ListBox listBoxGenre;
        private System.Windows.Forms.Label labelGenre;
    }
}

