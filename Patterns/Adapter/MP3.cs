namespace Adapter
{
    public class MP3
    {
        public MP3(string songName, string artist, double size, int bit, string data)
        {
            SongName = songName;
            Artist = artist;
            Size = size;
            Bit = bit;
            Data = data;
        }

        public string SongName { get; set; }
        public string Artist { get; set; }
        public double Size { get; set; }
        public int Bit { get; set; }
        public string Data { get; set; }
    }
}