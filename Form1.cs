using System;
using System.IO;
using System.Windows.Forms;

using NAudio.Lame;
using NAudio.Wave;


namespace WavToMP3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBoxBitRate.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {            
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                string directoryName;

                buttonSelectDirectory.Enabled = false;
                directoryName = folderBrowserDialog1.SelectedPath;
                textBoxArtistName.Text = new DirectoryInfo(directoryName).Name;
                Application.DoEvents();
                DialogResult result = MessageBox.Show("Ready to start the conversion?", "Confirmation", MessageBoxButtons.YesNo);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    var files = System.IO.Directory.EnumerateFiles(directoryName, "*.wav");

                    foreach (string fileName in files)
                    {
                        textBoxProgress.AppendText("Processing " + fileName + "\n");
                        Application.DoEvents();
                        WavToMP3(fileName, fileName.Replace(".wav", ".mp3"), Int32.Parse(comboBoxBitRate.Text), textBoxArtistName.Text, textBoxAlbumName.Text, checkBoxID3Tags.Checked);
                        if (checkBoxDeleteSourceFiles.Checked)
                        {
                            textBoxProgress.AppendText("Deleting " + fileName + "\n");
                            System.IO.File.Delete(fileName);
                        }
                    }

                    textBoxProgress.AppendText("Finished.\n");
                }
                buttonSelectDirectory.Enabled = true;
            }
        }



        /// <summary>
        ///  Convert WAV to MP3 using libmp3lame library
        /// </summary>
        /// <param name="waveFileName">WAV filename</param>
        /// <param name="mp3FileName">MP3 filename</param>
        /// <param name="bitRate">Bit rate, default 128</param>
        /// <param name="artist">Optional artist name</param>
        /// <param name="album">Optional album name</param>
        /// <param name="setID3Tags">Set ID3 tags</param>
        public static void WavToMP3(string waveFileName, string mp3FileName, int bitRate = 128, string artist = null, string album = null, bool setID3Tags = false)
        {
            ID3TagData tags = new ID3TagData();
            if (setID3Tags)
            {
                if (!String.IsNullOrEmpty(artist))
                {
                    tags.Artist = artist;
                    tags.Album = album;
                    tags.Genre = String.Empty;
                }
            }

            using (var reader = new WaveFileReader(waveFileName))
            using (var writer = new LameMP3FileWriter(mp3FileName, reader.WaveFormat, bitRate, tags))
                reader.CopyTo(writer);
        }

        // Convert MP3 file to WAV using NAudio classes only
        public static void MP3ToWave(string mp3FileName, string waveFileName)
        {
            using (var reader = new Mp3FileReader(mp3FileName))
            using (var writer = new WaveFileWriter(waveFileName, reader.WaveFormat))
                reader.CopyTo(writer);
        }

    }
}
