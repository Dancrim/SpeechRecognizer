using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace UCSpeechTranslator.AudioSource
{
    public class AudioSource
    {
        public string AudioAdress;
        public string BinaryFileName;

        public void GetBinaryAudio(string AudioAdress, string BinaryFileName)
        {
            var AudioFile = File.ReadAllBytes(AudioAdress);
            File.WriteAllBytes(BinaryFileName, AudioFile);
        }
    }
}
