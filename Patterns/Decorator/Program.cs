namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            IWeapon weapon = new Ak47();
            weapon.ShowProporties();

            IWeapon updatedWeapon1 = new SilencerUpdate(weapon);
            updatedWeapon1.ShowProporties();

            IWeapon updatedWeapon = new ScopeUptade(updatedWeapon1);
            updatedWeapon.ShowProporties();

            IWeapon updatedWeapon2 = new BulletUpdate(updatedWeapon);
            updatedWeapon2.ShowProporties();

            IWeapon unwreapped = (updatedWeapon2 as UpdateWeapon).UnWrapp();
            unwreapped.ShowProporties();
        }
    }

}
