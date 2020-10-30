using System;
using System.Collections.Generic;
using System.Text;

namespace Object_Pool
{
    class EnemyPool
    {
        private Random rand = new Random();
        Queue<Enemy> queue = new Queue<Enemy>();
        public Enemy GetEnemy()
        {
            if (queue.Count != 0)
            {
                return queue.Dequeue();
            }
            return new Enemy() { Character = Convert.ToChar(rand.Next(65,75)), X = rand.Next(0,20), Y = rand.Next(0,20)};
        }
        public void ReturnEnemy(Enemy enemy)
        {
            queue.Enqueue(enemy);
        }
    }
}
