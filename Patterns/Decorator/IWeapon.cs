namespace Decorator
{
    public interface IWeapon
    {
        public int Aim { get; }
        public int Damage { get; }
        public int Capacity { get; }
        public void ShowProporties();
    }

}
