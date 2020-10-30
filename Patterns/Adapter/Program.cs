using System;
using System.Collections.Specialized;
using System.Net;
using System.Threading.Tasks;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            var myMusic = new WAW(192,24.3,320,"I belive I can fly, I belive I can touch the sky");
            var player = new OnlinePlayer();
            player.UploadMusic(new MP3Adapter(myMusic));
            player.PlayMusic();
        }

    }
}
