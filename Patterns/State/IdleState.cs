using System;

namespace State
{
    class IdleState : IEnemyState
    {
        public Enemy Enemy { get; set; }

        public void Action()
        {
            Console.WriteLine("Idle...");
        }
    }
}
