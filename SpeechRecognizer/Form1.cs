using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SpeechRecognizer;
namespace SpeechRecognizer
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void bOpenFile_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "mp3 files (*.mp3)|*.mp3|wav files (*.wav)|*.wav|All files (*.*)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                AudioSource.AudioSource audio = new AudioSource.AudioSource();
                audio.AudioAdress = openFileDialog1.FileName.Remove(openFileDialog1.FileName.IndexOf(openFileDialog1.SafeFileName)) + openFileDialog1.FileName;
                //userControl11.Controls.
                
            }
        }
    }
}
