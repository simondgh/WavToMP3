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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonSelectDirectory = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.checkBoxDeleteSourceFiles = new System.Windows.Forms.CheckBox();
            this.textBoxProgress = new System.Windows.Forms.TextBox();
            this.comboBoxBitRate = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxID3 = new System.Windows.Forms.GroupBox();
            this.listBoxGenre = new System.Windows.Forms.ListBox();
            this.labelGenre = new System.Windows.Forms.Label();
            this.checkBoxID3Tags = new System.Windows.Forms.CheckBox();
            this.labelAlbumName = new System.Windows.Forms.Label();
            this.textBoxAlbumName = new System.Windows.Forms.TextBox();
            this.labelArtistName = new System.Windows.Forms.Label();
            this.textBoxArtistName = new System.Windows.Forms.TextBox();
            this.groupBoxID3.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonSelectDirectory
            // 
            resources.ApplyResources(this.buttonSelectDirectory, "buttonSelectDirectory");
            this.buttonSelectDirectory.Name = "buttonSelectDirectory";
            this.buttonSelectDirectory.UseVisualStyleBackColor = true;
            this.buttonSelectDirectory.Click += new System.EventHandler(this.button1_Click);
            // 
            // folderBrowserDialog1
            // 
            resources.ApplyResources(this.folderBrowserDialog1, "folderBrowserDialog1");
            // 
            // checkBoxDeleteSourceFiles
            // 
            resources.ApplyResources(this.checkBoxDeleteSourceFiles, "checkBoxDeleteSourceFiles");
            this.checkBoxDeleteSourceFiles.Name = "checkBoxDeleteSourceFiles";
            this.checkBoxDeleteSourceFiles.UseVisualStyleBackColor = true;
            // 
            // textBoxProgress
            // 
            resources.ApplyResources(this.textBoxProgress, "textBoxProgress");
            this.textBoxProgress.Name = "textBoxProgress";
            this.textBoxProgress.ReadOnly = true;
            // 
            // comboBoxBitRate
            // 
            resources.ApplyResources(this.comboBoxBitRate, "comboBoxBitRate");
            this.comboBoxBitRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBitRate.FormattingEnabled = true;
            this.comboBoxBitRate.Items.AddRange(new object[] {
            resources.GetString("comboBoxBitRate.Items"),
            resources.GetString("comboBoxBitRate.Items1")});
            this.comboBoxBitRate.Name = "comboBoxBitRate";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // groupBoxID3
            // 
            resources.ApplyResources(this.groupBoxID3, "groupBoxID3");
            this.groupBoxID3.Controls.Add(this.listBoxGenre);
            this.groupBoxID3.Controls.Add(this.labelGenre);
            this.groupBoxID3.Controls.Add(this.checkBoxID3Tags);
            this.groupBoxID3.Controls.Add(this.labelAlbumName);
            this.groupBoxID3.Controls.Add(this.textBoxAlbumName);
            this.groupBoxID3.Controls.Add(this.labelArtistName);
            this.groupBoxID3.Controls.Add(this.textBoxArtistName);
            this.groupBoxID3.Name = "groupBoxID3";
            this.groupBoxID3.TabStop = false;
            // 
            // listBoxGenre
            // 
            resources.ApplyResources(this.listBoxGenre, "listBoxGenre");
            this.listBoxGenre.FormattingEnabled = true;
            this.listBoxGenre.Items.AddRange(new object[] {
            resources.GetString("listBoxGenre.Items"),
            resources.GetString("listBoxGenre.Items1"),
            resources.GetString("listBoxGenre.Items2"),
            resources.GetString("listBoxGenre.Items3"),
            resources.GetString("listBoxGenre.Items4"),
            resources.GetString("listBoxGenre.Items5"),
            resources.GetString("listBoxGenre.Items6"),
            resources.GetString("listBoxGenre.Items7"),
            resources.GetString("listBoxGenre.Items8"),
            resources.GetString("listBoxGenre.Items9"),
            resources.GetString("listBoxGenre.Items10"),
            resources.GetString("listBoxGenre.Items11"),
            resources.GetString("listBoxGenre.Items12"),
            resources.GetString("listBoxGenre.Items13"),
            resources.GetString("listBoxGenre.Items14"),
            resources.GetString("listBoxGenre.Items15"),
            resources.GetString("listBoxGenre.Items16"),
            resources.GetString("listBoxGenre.Items17"),
            resources.GetString("listBoxGenre.Items18"),
            resources.GetString("listBoxGenre.Items19"),
            resources.GetString("listBoxGenre.Items20"),
            resources.GetString("listBoxGenre.Items21"),
            resources.GetString("listBoxGenre.Items22"),
            resources.GetString("listBoxGenre.Items23"),
            resources.GetString("listBoxGenre.Items24"),
            resources.GetString("listBoxGenre.Items25"),
            resources.GetString("listBoxGenre.Items26"),
            resources.GetString("listBoxGenre.Items27"),
            resources.GetString("listBoxGenre.Items28"),
            resources.GetString("listBoxGenre.Items29"),
            resources.GetString("listBoxGenre.Items30"),
            resources.GetString("listBoxGenre.Items31"),
            resources.GetString("listBoxGenre.Items32"),
            resources.GetString("listBoxGenre.Items33"),
            resources.GetString("listBoxGenre.Items34"),
            resources.GetString("listBoxGenre.Items35"),
            resources.GetString("listBoxGenre.Items36"),
            resources.GetString("listBoxGenre.Items37"),
            resources.GetString("listBoxGenre.Items38"),
            resources.GetString("listBoxGenre.Items39"),
            resources.GetString("listBoxGenre.Items40"),
            resources.GetString("listBoxGenre.Items41"),
            resources.GetString("listBoxGenre.Items42"),
            resources.GetString("listBoxGenre.Items43"),
            resources.GetString("listBoxGenre.Items44"),
            resources.GetString("listBoxGenre.Items45"),
            resources.GetString("listBoxGenre.Items46"),
            resources.GetString("listBoxGenre.Items47"),
            resources.GetString("listBoxGenre.Items48"),
            resources.GetString("listBoxGenre.Items49"),
            resources.GetString("listBoxGenre.Items50"),
            resources.GetString("listBoxGenre.Items51"),
            resources.GetString("listBoxGenre.Items52"),
            resources.GetString("listBoxGenre.Items53"),
            resources.GetString("listBoxGenre.Items54"),
            resources.GetString("listBoxGenre.Items55"),
            resources.GetString("listBoxGenre.Items56"),
            resources.GetString("listBoxGenre.Items57"),
            resources.GetString("listBoxGenre.Items58"),
            resources.GetString("listBoxGenre.Items59"),
            resources.GetString("listBoxGenre.Items60"),
            resources.GetString("listBoxGenre.Items61"),
            resources.GetString("listBoxGenre.Items62"),
            resources.GetString("listBoxGenre.Items63"),
            resources.GetString("listBoxGenre.Items64"),
            resources.GetString("listBoxGenre.Items65"),
            resources.GetString("listBoxGenre.Items66"),
            resources.GetString("listBoxGenre.Items67"),
            resources.GetString("listBoxGenre.Items68"),
            resources.GetString("listBoxGenre.Items69"),
            resources.GetString("listBoxGenre.Items70"),
            resources.GetString("listBoxGenre.Items71"),
            resources.GetString("listBoxGenre.Items72"),
            resources.GetString("listBoxGenre.Items73"),
            resources.GetString("listBoxGenre.Items74"),
            resources.GetString("listBoxGenre.Items75"),
            resources.GetString("listBoxGenre.Items76"),
            resources.GetString("listBoxGenre.Items77"),
            resources.GetString("listBoxGenre.Items78"),
            resources.GetString("listBoxGenre.Items79"),
            resources.GetString("listBoxGenre.Items80"),
            resources.GetString("listBoxGenre.Items81"),
            resources.GetString("listBoxGenre.Items82"),
            resources.GetString("listBoxGenre.Items83"),
            resources.GetString("listBoxGenre.Items84"),
            resources.GetString("listBoxGenre.Items85"),
            resources.GetString("listBoxGenre.Items86"),
            resources.GetString("listBoxGenre.Items87"),
            resources.GetString("listBoxGenre.Items88"),
            resources.GetString("listBoxGenre.Items89"),
            resources.GetString("listBoxGenre.Items90"),
            resources.GetString("listBoxGenre.Items91"),
            resources.GetString("listBoxGenre.Items92"),
            resources.GetString("listBoxGenre.Items93"),
            resources.GetString("listBoxGenre.Items94"),
            resources.GetString("listBoxGenre.Items95"),
            resources.GetString("listBoxGenre.Items96"),
            resources.GetString("listBoxGenre.Items97"),
            resources.GetString("listBoxGenre.Items98"),
            resources.GetString("listBoxGenre.Items99"),
            resources.GetString("listBoxGenre.Items100"),
            resources.GetString("listBoxGenre.Items101"),
            resources.GetString("listBoxGenre.Items102"),
            resources.GetString("listBoxGenre.Items103"),
            resources.GetString("listBoxGenre.Items104"),
            resources.GetString("listBoxGenre.Items105"),
            resources.GetString("listBoxGenre.Items106"),
            resources.GetString("listBoxGenre.Items107"),
            resources.GetString("listBoxGenre.Items108"),
            resources.GetString("listBoxGenre.Items109"),
            resources.GetString("listBoxGenre.Items110"),
            resources.GetString("listBoxGenre.Items111"),
            resources.GetString("listBoxGenre.Items112"),
            resources.GetString("listBoxGenre.Items113"),
            resources.GetString("listBoxGenre.Items114"),
            resources.GetString("listBoxGenre.Items115"),
            resources.GetString("listBoxGenre.Items116"),
            resources.GetString("listBoxGenre.Items117"),
            resources.GetString("listBoxGenre.Items118"),
            resources.GetString("listBoxGenre.Items119"),
            resources.GetString("listBoxGenre.Items120"),
            resources.GetString("listBoxGenre.Items121"),
            resources.GetString("listBoxGenre.Items122"),
            resources.GetString("listBoxGenre.Items123"),
            resources.GetString("listBoxGenre.Items124"),
            resources.GetString("listBoxGenre.Items125"),
            resources.GetString("listBoxGenre.Items126"),
            resources.GetString("listBoxGenre.Items127"),
            resources.GetString("listBoxGenre.Items128"),
            resources.GetString("listBoxGenre.Items129"),
            resources.GetString("listBoxGenre.Items130"),
            resources.GetString("listBoxGenre.Items131"),
            resources.GetString("listBoxGenre.Items132"),
            resources.GetString("listBoxGenre.Items133"),
            resources.GetString("listBoxGenre.Items134"),
            resources.GetString("listBoxGenre.Items135"),
            resources.GetString("listBoxGenre.Items136"),
            resources.GetString("listBoxGenre.Items137"),
            resources.GetString("listBoxGenre.Items138"),
            resources.GetString("listBoxGenre.Items139"),
            resources.GetString("listBoxGenre.Items140"),
            resources.GetString("listBoxGenre.Items141"),
            resources.GetString("listBoxGenre.Items142"),
            resources.GetString("listBoxGenre.Items143"),
            resources.GetString("listBoxGenre.Items144"),
            resources.GetString("listBoxGenre.Items145"),
            resources.GetString("listBoxGenre.Items146"),
            resources.GetString("listBoxGenre.Items147"),
            resources.GetString("listBoxGenre.Items148")});
            this.listBoxGenre.Name = "listBoxGenre";
            // 
            // labelGenre
            // 
            resources.ApplyResources(this.labelGenre, "labelGenre");
            this.labelGenre.Name = "labelGenre";
            // 
            // checkBoxID3Tags
            // 
            resources.ApplyResources(this.checkBoxID3Tags, "checkBoxID3Tags");
            this.checkBoxID3Tags.Name = "checkBoxID3Tags";
            this.checkBoxID3Tags.UseVisualStyleBackColor = true;
            this.checkBoxID3Tags.CheckedChanged += new System.EventHandler(this.checkBoxID3Tags_CheckedChanged);
            // 
            // labelAlbumName
            // 
            resources.ApplyResources(this.labelAlbumName, "labelAlbumName");
            this.labelAlbumName.Name = "labelAlbumName";
            // 
            // textBoxAlbumName
            // 
            resources.ApplyResources(this.textBoxAlbumName, "textBoxAlbumName");
            this.textBoxAlbumName.Name = "textBoxAlbumName";
            // 
            // labelArtistName
            // 
            resources.ApplyResources(this.labelArtistName, "labelArtistName");
            this.labelArtistName.Name = "labelArtistName";
            // 
            // textBoxArtistName
            // 
            resources.ApplyResources(this.textBoxArtistName, "textBoxArtistName");
            this.textBoxArtistName.Name = "textBoxArtistName";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBoxID3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxBitRate);
            this.Controls.Add(this.textBoxProgress);
            this.Controls.Add(this.checkBoxDeleteSourceFiles);
            this.Controls.Add(this.buttonSelectDirectory);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
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

