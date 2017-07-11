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
namespace UCSpeechTranslator
{
     
    public partial class UserControl1 : UserControl
    {
        String ahaha;
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();
        public UserControl1()
        {
            InitializeComponent();
        }
        bool playing;
       
        public void qwerg(string AudioAdress)
        {
            playing = false;
            player.SoundLocation = AudioAdress;
            label1.Text = player.SoundLocation;
            ahaha = player.SoundLocation;
        }

        private void PlayButton_Click(object sender, EventArgs e)
        {
            player.SoundLocation = ahaha;
            if (!playing)
            {
            
                    player.Play();
                playing = true;
            }
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
         
            if (playing)
            {
                player.Stop();
                playing = false;
            }

        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
           // SaveFileDialog sfd = new SaveFileDialog();
           // if (sfd.ShowDialog() == DialogResult.OK)
             //   File.WriteAllText(sfd.FileName, textBox1.Text);
            int y = 0;
        }

    }
}
