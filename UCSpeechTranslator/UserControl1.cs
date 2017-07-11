using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using NAudio;
using NAudio.Wave;
namespace UCSpeechTranslator
{
     
    public partial class UserControl1 : UserControl
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();
        IWavePlayer waveOutDevice = new WaveOut();
        AudioFileReader audioFileReader;
        bool playing;
        public UserControl1()
        {
            InitializeComponent();
        }

        public void SetWay(string AudioAdress)
        {
            playing = false;
            label1.Text = AudioAdress;
        }

        private void PlayButton_Click(object sender, EventArgs e)
        {
            if (!playing)
            {
                System.IO.StreamReader sr = new StreamReader("in.txt");
                string tmp = sr.ReadLine();
                if (tmp.Substring(tmp.Length - 3, 3) == "mp3")
                {
                    audioFileReader = new AudioFileReader(tmp);
                    waveOutDevice.Init(audioFileReader);
                    waveOutDevice.Play();
                }
                else
                {
                    player.SoundLocation = sr.ReadLine();
                    player.Play();
                }
                playing = true;
                sr.Close();
            }
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            if (playing)
            {
                System.IO.StreamReader sr = new StreamReader("in.txt");
                string tmp = sr.ReadLine();
                if (tmp.Substring(tmp.Length - 3, 3) == "mp3")
                    waveOutDevice.Stop();
                else
                    player.Stop();
                playing = false;
                sr.Close();
            }
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            //SaveFileDialog sfd = new SaveFileDialog();
            //if (sfd.ShowDialog() == DialogResult.OK)
            //    File.WriteAllText(sfd.FileName, textBox1.Text);


        }
    }
}
