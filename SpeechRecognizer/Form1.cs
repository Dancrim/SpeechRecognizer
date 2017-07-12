using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UCSpeechTranslator;
namespace SpeechRecognizer {
    public partial class MainForm : Form {
        AudioSource.AudioSource audio = new AudioSource.AudioSource();

        public MainForm() {
            InitializeComponent();
        }

        private void bOpenFile_Click(object sender, EventArgs e) {
            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "mp3 files (*.mp3)|*.mp3|wav files (*.wav)|*.wav|All files (*.*)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK) {
                var sw = new System.IO.StreamWriter("adress.txt");
                sw.WriteLine(openFileDialog1.FileName);
                sw.Close();
                UCSpeechTranslator.AudioFile = openFileDialog1.FileName;
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
