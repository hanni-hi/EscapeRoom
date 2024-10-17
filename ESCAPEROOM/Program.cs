using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Media;

namespace ESCAPEROOM
{
    class Program
    {
        static void Main(string[] args)
        {
            PlayMusicLoop("bgm.wav");
            Story.Intro();
            while (true)
            {
                Story.Room1();
            }
        }
        public static void Playmusic(string filepath)
        {
            SoundPlayer musicPlayer = new SoundPlayer();
            musicPlayer.SoundLocation = filepath;
            musicPlayer.PlaySync();
        }
        public static void PlayMusicLoop(string filepath)
        {
            SoundPlayer musicPlayer = new SoundPlayer(filepath);
            musicPlayer.PlayLooping(); // 배경 음악을 무한 루프로 재생
        }
    }
}
