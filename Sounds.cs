/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WMPLib;

namespace Uss_1
{
    public class Sounds
    {
        WindowsMediaPlayer player = new WindowsMediaPlayer();
        private string pathToMedia;

        public Sounds(string pathToResources)
        {
            pathToMedia = pathToResources;
        }
        public void Play()//Создание проигрывателя заднего фона
        {
            player.URL = pathToMedia + "Background.mp3";
            player.settings.volume = 100;
            player.controls.play();
            player.settings.setMode("loop", true);
        }
        public void PlayEat()//создание проигрывателя поедания еды
        {
            player.URL = pathToMedia + "Eat.mp3";
            player.settings.volume = 50;
            player.controls.play();
        }
        public void Play(string songName)
        {
            player.URL = pathToMedia + songName + ".mp3";
            player.controls.play();
        }
        public void Deads()//создание проигрывателя смерти
        {
            player.URL = pathToMedia + "GameOver.mp3";
            player.settings.volume = 100;
            player.controls.play();
        }

    }
}*/