using System;
using System.Globalization;
using System.IO;
using System.Windows.Forms;
using System.Resources;

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
                ResourceManager LocRM = new ResourceManager("WavToMP3.WinFormStrings", typeof(Form1).Assembly);
                                

                string directoryName;

                buttonSelectDirectory.Enabled = false;
                directoryName = folderBrowserDialog1.SelectedPath;
                textBoxArtistName.Text = new DirectoryInfo(directoryName).Name;
                Application.DoEvents();
                DialogResult result = MessageBox.Show(LocRM.GetString("stringReadyToStartConversion"), LocRM.GetString("stringConfirmation"), MessageBoxButtons.YesNo);
                bool success;

                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    var files = System.IO.Directory.EnumerateFiles(directoryName, "*.wav");

                    foreach (string fileName in files)
                    {
                        textBoxProgress.AppendText(LocRM.GetString("stringProcessing") + " " + fileName + "\n");
                        Application.DoEvents();
                        success = WavToMP3(fileName, fileName.Replace(".wav", ".mp3"), Int32.Parse(comboBoxBitRate.Text), textBoxArtistName.Text, textBoxAlbumName.Text, checkBoxID3Tags.Checked, listBoxGenre.SelectedIndex.ToString());
                        if (!success)
                        {
                            textBoxProgress.AppendText(LocRM.GetString("stringCouldntConvert") + " " + fileName + "\n");
                        }

                        if (success && checkBoxDeleteSourceFiles.Checked)
                        {
                            textBoxProgress.AppendText(LocRM.GetString("stringDeleting") + " " + fileName + "\n");
                            System.IO.File.Delete(fileName);
                        }
                    }

                    textBoxProgress.AppendText(LocRM.GetString("stringFinished") + "\n");
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
        public static bool WavToMP3(string waveFileName, string mp3FileName, int bitRate = 128, string artist = null, string album = null, bool setID3Tags = false, string genre = "148")
        {
            bool result = true;
            try
            {
                ID3TagData tags = new ID3TagData();
                if (setID3Tags)
                {
                    if (!String.IsNullOrEmpty(artist))
                    {
                        tags.Artist = artist;
                        tags.Album = album;
                        tags.Genre = genre;
                    }
                }

                using (var reader = new WaveFileReader(waveFileName))
                using (var writer = new LameMP3FileWriter(mp3FileName, reader.WaveFormat, bitRate, tags))
                    reader.CopyTo(writer);

            }
            catch (Exception)
            {
                result = false;
            }

            return result;
        }

        /// <summary>
        /// Convert MP3 file to WAV using NAudio classes only
        /// </summary>
        /// <param name="mp3FileName">MP3 filename</param>
        /// <param name="waveFileName">WAV filename</param>
        public static void MP3ToWav(string mp3FileName, string waveFileName)
        {
            using (var reader = new Mp3FileReader(mp3FileName))
            using (var writer = new WaveFileWriter(waveFileName, reader.WaveFormat))
                reader.CopyTo(writer);
        }

        private void checkBoxID3Tags_CheckedChanged(object sender, EventArgs e)
        {
            textBoxArtistName.Enabled = textBoxAlbumName.Enabled =  listBoxGenre.Enabled =  checkBoxID3Tags.Checked; 
        }

    }
}
