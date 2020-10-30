using System;

namespace Object_Pool
{
    class Program
    {
        static void Main(string[] args)
        {
            var pool = new EnemyPool();
            var enemy = pool.GetEnemy();
            PrintEnemy(enemy);
            var enemy1 = pool.GetEnemy();
            PrintEnemy(enemy1);
            var enemy2 = pool.GetEnemy();
            PrintEnemy(enemy2);
            Console.ReadKey();
            Console.Clear();
            Console.ReadKey();

            pool.ReturnEnemy(enemy);
            pool.ReturnEnemy(enemy1);
            var enemy3 = pool.GetEnemy();
            PrintEnemy(enemy3);
            Console.ReadKey();

        }
        public static void PrintEnemy(Enemy enemy)
        {
            Console.SetCursorPosition(enemy.X, enemy.Y);
            Console.WriteLine(enemy.Character);
        }
    }
}
