namespace Builder
{
    public enum Side
    {
        Left, Right
    }
    public class Door
    {
        public Side Side { get; set; }
        public Door(Side side)
        {
            Side = side;
        }
        public override string ToString()
        {
            return Side.ToString() + " door";
        }
    }
}