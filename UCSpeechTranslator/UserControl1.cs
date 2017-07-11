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
using UCSpeechTranslator.YandexWrapper;
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
                {
                    audioFileReader = new AudioFileReader(tmp);
                    waveOutDevice.Init(audioFileReader);
                    waveOutDevice.Play();
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
                    waveOutDevice.Stop();
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

        private void button1_Click(object sender, EventArgs e)
        {
            System.IO.StreamReader sr = new StreamReader("in.txt");
            //AudioSource.AudioSource audio = new AudioSource.AudioSource();
            string qwe = sr.ReadLine();
            textBox1.Text = UCSpeechTranslator.YandexWrapper.YandexWrapper.GetAudioText(qwe);
            int n = 0;
            n++;
        }
    }
}
