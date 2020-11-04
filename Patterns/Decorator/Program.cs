namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            IWeapon weapon = new Ak47();
            weapon.ShowProporties();
            IWeapon updatedWeapon = new ScopeUptade(weapon);
            updatedWeapon.ShowProporties();

            IWeapon updatedWeapon1 = new SilencerUpdate(updatedWeapon);
            updatedWeapon1.ShowProporties();

            IWeapon updatedWeapon2 = new BulletUpdate(updatedWeapon1);
            updatedWeapon2.ShowProporties();

            IWeapon unwreapped = (updatedWeapon2 as UpdateWeapon).UnWrapp();
            unwreapped.ShowProporties();
        }
    }

}
