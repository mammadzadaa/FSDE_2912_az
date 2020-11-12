using System;

namespace State
{
    class LowHPState : IEnemyState
    {
        public Enemy Enemy { get; set; }
        public void Action()
        {
            Console.WriteLine("Run away and hide!");
        }
    }
}
