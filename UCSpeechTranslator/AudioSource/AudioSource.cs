using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace UCSpeechTranslator.AudioSource {
    public class AudioSource {
        /*поправить поля, установить гет и сет, убрать методы*/
        public string AudioAdress;
        //    { get { return  }
        //}
        public string APIKey;
        public string Topic;
        public byte[] BinarySource;
        public void SetAudioAdress(AudioSource obj) {
            StreamReader sr = new StreamReader("adress.txt");
            obj.AudioAdress = sr.ReadLine();
        }
        public void SetAPIKey(AudioSource obj) {
            StreamReader sr = new StreamReader("apikey.txt");
            obj.APIKey = sr.ReadLine();
        }
        public void SetTopic(AudioSource obj) {
            StreamReader sr = new StreamReader("topic.txt");
            obj.Topic = sr.ReadLine();
        }
        public void SetBinarySource(AudioSource obj) {
            //  StreamReader sr = new StreamReader(obj.AudioAdress);
            //  obj.BinarySource = Encoding.ASCII.GetBytes(sr.ReadToEnd());
            obj.BinarySource = File.ReadAllBytes(obj.AudioAdress);
        }
    }
}
