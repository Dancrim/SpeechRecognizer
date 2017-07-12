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
namespace UCSpeechTranslator {

    public partial class UserControl1 : UserControl {
        //расширить форму и юзерконтрол, чтобы было все видно
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();
        IWavePlayer waveOutDevice = new WaveOut();
        AudioFileReader audioFileReader;
        public string AudioFile {
            get { return label1.Text; }
            set { label1.Text = value; }
        }
        public UserControl1() {
            InitializeComponent();
        }

        private void PlayButton_Click(object sender, EventArgs e) {
            var obj = new AudioSource.AudioSource();
            obj.SetAudioAdress(obj);
            //System.IO.StreamReader sr = new StreamReader("in.txt");
            //string tmp = sr.ReadLine();
            audioFileReader = new AudioFileReader(obj.AudioAdress);
            waveOutDevice.Init(audioFileReader);
            waveOutDevice.Play();
            //sr.Close();
        }

        private void StopButton_Click(object sender, EventArgs e) {
            //System.IO.StreamReader sr = new StreamReader("in.txt");
            //string tmp = sr.ReadLine();
            waveOutDevice.Stop();
            //sr.Close();
        }

        private void UserControl1_Load(object sender, EventArgs e) {

        }

        private void button1_Click(object sender, EventArgs e) {
            var Audio = new AudioSource.AudioSource();
            textBox1.Text = UCSpeechTranslator.YandexWrapper.YandexWrapper.GetAudioText(Audio);
        }

        //private void bOpenFile_Click(object sender, EventArgs e)
        //{
        //    label1.Text = "Путь:";
        //    openFileDialog1.InitialDirectory = "c:\\";
        //    openFileDialog1.Filter = "mp3 files (*.mp3)|*.mp3|wav files (*.wav)|*.wav|All files (*.*)|*.*";
        //    if (openFileDialog1.ShowDialog() == DialogResult.OK)
        //    {
        //        var sw = new System.IO.StreamWriter("adress.txt");
        //        sw.WriteLine(openFileDialog1.FileName);
        //        sw.Close();
        //    }
        //    label1.Text += openFileDialog1.FileName;
        //}
    }
}
