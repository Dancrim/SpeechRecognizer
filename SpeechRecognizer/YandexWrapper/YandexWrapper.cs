﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AudioTranslator.AudioSource;

namespace AudioTranslator.YandexWrapper
{
    class YandexWrapper
    {
        public string AudioText;

        public string GetAudioText()
        {
            var Audio = new AudioSource.AudioSource();
            Audio.GetBinaryAudio(Audio.AudioAdress, Audio.BinaryFileName);
            //тут продолжить
            return AudioText;
        }
    }
}
