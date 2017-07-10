using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace UCSpeechTranslator
{

    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }
        bool playing = false;
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();
        public void qwerg(string AudioAdress)
        {
            player.SoundLocation = AudioAdress;
            player.Load();
            label1.Text = player.SoundLocation;
        }
        private void Play(string AudioAdress)
        {
            if (!playing)
            {
                player.Play();
                playing = true;
            }
        }
        private void Stop(string AudioAdress)
        {
            if (playing)
            {
                player.Stop();
                playing = false;
            }
        }
        private void PlayButton_Click(object sender, EventArgs e)
        {
            //берётся путь и записывается в AudioAdress
            Play(label1.Text);
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            //берётся путь и записывается в AudioAdress
            Stop(label1.Text);
        }



    }
}
