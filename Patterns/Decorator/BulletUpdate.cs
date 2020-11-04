namespace Decorator
{
    public class BulletUpdate : UpdateWeapon
    {
        public BulletUpdate(IWeapon weapon) : base(weapon)
        {
            additionalAim = -10;
            additionalDamage = 20;
            additionalCapacity = -5;
        }
    }

}
