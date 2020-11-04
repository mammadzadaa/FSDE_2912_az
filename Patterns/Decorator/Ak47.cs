using System;

namespace Decorator
{
    public class Ak47 : IWeapon
    {
        public int Aim { get; } = 20;

        public int Damage { get; } = 50;

        public int Capacity { get; } = 30;

        public void ShowProporties()
        {
            Console.WriteLine($"Aiming: {Aim}\nDamage: {Damage}\nCapacity: {Capacity}\n\n");
        }
    }

}
