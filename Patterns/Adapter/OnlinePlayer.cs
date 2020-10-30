using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    class OnlinePlayer
    {
        private MP3 music;
        public void UploadMusic(MP3 music)
        {
            this.music = music;
        }
        public void PlayMusic()
        {
            Console.WriteLine($"{music.Artist} {music.SongName}\n"+
                                $"Bitrate: {music.Bit} bit\n" +
                                $"Size: {music.Size} MB\n" +
                                $"Song: {music.Data}");
        }

    }
}
