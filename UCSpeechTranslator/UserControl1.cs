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
        /*
          player.SoundLocation = AudioAdress;
            player.Load();
         */
        private void Play(string AudioAdress)
        {
            if (!playing)
                player.Play();
        }
        private void Stop(string AudioAdress)
        {
            if (playing)
                player.Stop();
        }
        private void PlayButton_Click(object sender, EventArgs e)
        {
            //берётся путь и записывается в AudioAdress
            // Play(AudioAdress);
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            //берётся путь и записывается в AudioAdress
            //Stop(AudioAdress);
        }



    }
}
