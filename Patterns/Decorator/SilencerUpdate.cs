namespace Decorator
{
    public class SilencerUpdate : UpdateWeapon
    {
        public SilencerUpdate(IWeapon weapon) : base(weapon)
        {
            additionalAim = 3;
            additionalDamage = -5;
            additionalCapacity = 0;
        }
    }

}
