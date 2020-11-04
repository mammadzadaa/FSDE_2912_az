using System;

namespace Decorator
{
    public abstract class UpdateWeapon : IWeapon
    {
        private IWeapon weapon;
        public UpdateWeapon(IWeapon weapon)
        {
            this.weapon = weapon;
        }
        protected int additionalAim;
        protected int additionalDamage;
        protected int additionalCapacity;
        public int Aim => weapon.Aim + additionalAim;

        public int Damage => weapon.Damage + additionalDamage;

        public int Capacity => weapon.Capacity + additionalCapacity;
        public IWeapon UnWrapp()
        {
            return weapon;
        }
        public void ShowProporties()
        {
             Console.WriteLine($"Aiming: {Aim}\nDamage: {Damage}\nCapacity: {Capacity}\n\n");
        }
    }

}
