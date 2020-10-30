namespace Adapter
{
    public class WAW
    {
        public WAW(int durationSeconds, double size, int bit, string data)
        {
            DurationSeconds = durationSeconds;
            Size = size;
            Bit = bit;
            Data = data;
        }

        public int DurationSeconds { get; set; }
        public double Size { get; set; }
        public int Bit { get; set; }
        public string Data { get; set; }
    
    }
}