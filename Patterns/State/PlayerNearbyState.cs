using System;

namespace State
{
    class PlayerNearbyState : IEnemyState
    {
        public Enemy Enemy { get; set; }
        public void Action()
        {
            if (Enemy.HP > 10)
            {
                Console.WriteLine("Attack player!");
            }
            else
            {
                Enemy.CurrentState = new LowHPState() {Enemy = Enemy};
            }
        }
    }
}
