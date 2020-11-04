namespace Decorator
{
    public class ScopeUptade : UpdateWeapon
    {
        
        public ScopeUptade(IWeapon weapon) : base(weapon)
        {
            additionalAim = 10;
            additionalCapacity = 0;
            additionalDamage = 0;
        }
    }

}
