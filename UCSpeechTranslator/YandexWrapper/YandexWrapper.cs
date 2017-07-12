using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UCSpeechTranslator.AudioSource;
using System.IO;
using System.Net;
using System.Xml;

namespace UCSpeechTranslator.YandexWrapper {
    public class YandexWrapper {
        public static string AudioText;
        public static string PostMethod(AudioSource.AudioSource obj) {
            obj.SetAudioAdress(obj);
            obj.SetAPIKey(obj);
            obj.SetTopic(obj);
            obj.SetBinarySource(obj);
            string postUrl = "https://asr.yandex.net/asr_xml?uuid=2606A62EE2C5F840849C7F360FE3E67B&key=" + obj.APIKey + "&" + "topic=" + obj.Topic;
            //"uuid=2606A62EE2C5F840849C7F360FE3E67B&"
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(postUrl);
            request.Method = "POST";
            request.Host = "asr.yandex.net";
            request.SendChunked = false;
            //request.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/42.0.2311.135 Safari/537.36 Edge/12.10240";
            request.ContentType = "audio/x-wav";
            request.ContentLength = obj.BinarySource.Length;
            using (var newStream = request.GetRequestStream()) {
                newStream.Write(obj.BinarySource, 0, obj.BinarySource.Length);
            }
            string responseToString = "";
            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse()) {
                using (Stream datastream = response.GetResponseStream()) {
                    using (StreamReader sr = new StreamReader(datastream)) {
                        responseToString = sr.ReadToEnd();
                    }
                }
            }
            //дописать вырезку текста из responseToString
            XmlDocument doc = new XmlDocument();

            return responseToString;
        }
        public static string GetAudioText(AudioSource.AudioSource Audio) {
            Audio = new AudioSource.AudioSource();
            AudioText = PostMethod(Audio);
            return AudioText;
        }


    }
}