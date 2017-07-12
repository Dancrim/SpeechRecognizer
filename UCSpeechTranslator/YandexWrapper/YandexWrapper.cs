using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UCSpeechTranslator.AudioSource;
using System.IO;
using System.Net;
using System.Xml;

namespace UCSpeechTranslator.YandexWrapper
{
    public class YandexWrapper
    {
        public static string AudioText;
        public static string PostMethod(AudioSource.AudioSource obj)
        {
            string uuid = Guid.NewGuid().ToString().Replace("-", "");
            string postUrl = "https://asr.yandex.net/asr_xml?uuid=" + uuid + "&key=" + obj.APIKey + "&" + "topic=" + obj.Topic;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(postUrl);
            request.Method = "POST";
            request.Host = "asr.yandex.net";
            request.SendChunked = false;
            if (obj.AudioAdress.Substring(obj.AudioAdress.Length - 3, 3) == "mp3")
                request.ContentType = "audio/x-mpeg-3";
            else if (obj.AudioAdress.Substring(obj.AudioAdress.Length - 3, 3) == "wav")
                request.ContentType = "audio/x-wav";
            request.ContentLength = obj.BinarySource.Length;
            using (var newStream = request.GetRequestStream())
            {
                newStream.Write(obj.BinarySource, 0, obj.BinarySource.Length);
                newStream.Close();
            }
            string responseToString = "";
            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            {
                using (Stream datastream = response.GetResponseStream())
                {
                    using (StreamReader sr = new StreamReader(datastream))
                    {
                        responseToString = sr.ReadToEnd();
                        sr.Close();
                    }
                    datastream.Close();
                }
                response.Close();
            }
            XmlDocument doc = new XmlDocument();
            doc.InnerXml = responseToString;
            XmlNode elem = doc.DocumentElement.FirstChild;
            responseToString = elem.InnerText;
            return responseToString;
        }
        public static string GetAudioText(AudioSource.AudioSource Audio)
        {
            Audio = new AudioSource.AudioSource();
            AudioText = PostMethod(Audio);
            return AudioText;
        }
    }
}