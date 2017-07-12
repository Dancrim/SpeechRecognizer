using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UCSpeechTranslator.AudioSource;
using System.IO;
using System.Net;

namespace UCSpeechTranslator.YandexWrapper
{
    public class YandexWrapper
    {
        public static string AudioText;
        public static string PostMethod(AudioSource.AudioSource obj)
        {
            obj.SetAudioAdress(obj);
            obj.SetAPIKey(obj);
            obj.SetTopic(obj);
            obj.SetBinarySource(obj);
            string postUrl = "https://asr.yandex.net/asr_xml?" + Guid.NewGuid() + "&key=" + obj.APIKey + "&" + "topic=" + obj.Topic;
            //"uuid=2606A62EE2C5F840849C7F360FE3E67B&"
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(postUrl);
            request.Method = "POST";
            request.Host = "asr.yandex.net";
            request.SendChunked = true;
            request.UserAgent = "Oleg"; 
            request.ContentType = "audio/x-mpeg-3";
            request.ContentLength = obj.BinarySource.Length;
            using (var newStream = request.GetRequestStream())
            {
                newStream.Write(obj.BinarySource, 0, obj.BinarySource.Length);
            }
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            string responseToString = "";
            if (response != null)
            {
                var strreader = new StreamReader(response.GetResponseStream(), Encoding.UTF8);
                responseToString = strreader.ReadToEnd();
            }
            int index = responseToString.IndexOf("<variant confidence=\"1\">");
        //    responseToString = responseToString.Substring(index + 24, responseToString.Length - index - 24);
            int index2 = responseToString.IndexOf("</variant>");
            responseToString = responseToString.Substring(0, index2);
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