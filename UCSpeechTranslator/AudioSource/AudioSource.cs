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
        public string AudioAdress
        {
            get
            {
                StreamReader swf = new StreamReader("adress.txt");
                string lol = swf.ReadLine();
                swf.Close();
                return lol;
            }
        }
        public string APIKey
        {
            get
            {
                StreamReader swf = new StreamReader("apikey.txt");
                string lol = swf.ReadLine();
                swf.Close();
                return lol;
            }
        }
        public string Topic
        {
            get
            {
                StreamReader swf = new StreamReader("topic.txt");
                string lol = swf.ReadLine();
                swf.Close();
                return lol;
            }
        }
        public byte[] BinarySource
        {
            get
            {
                return File.ReadAllBytes(AudioAdress);
            }
        }
    }
}
