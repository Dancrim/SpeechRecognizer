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
    public partial class UCSpeechRecognizer : UserControl
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();
        IWavePlayer waveOutDevice = new WaveOut();
        AudioFileReader audioFileReader;
        public string AudioFile
        {
            get { return label1.Text; }
            set { label1.Text = value; }
        }
        public UCSpeechRecognizer()
        {
            InitializeComponent();
        }
        private void PlayButton_Click(object sender, EventArgs e)
        {
            var obj = new AudioSource.AudioSource();
            audioFileReader = new AudioFileReader(obj.AudioAdress);
            waveOutDevice.Init(audioFileReader);
            waveOutDevice.Play();
        }
        
        private void StopButton_Click(object sender, EventArgs e)
        {
            waveOutDevice.Stop();
        }
        private void Recognize_Click(object sender, EventArgs e)
        {
            var Audio = new AudioSource.AudioSource();
            textBox1.Text = "Please wait...";
            textBox1.Text = UCSpeechTranslator.YandexWrapper.YandexWrapper.PostMethod(Audio);
        }
    }
}
