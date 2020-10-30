using System;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            var robot = new Robot("Aftandil", "LEGO", "SumoBot", 2, 1.8, "Red",new Soft("3.2.1v") );

            var anotherRobot = robot.Clone() as Robot;
            anotherRobot.Name = "Israfil";
            anotherRobot.Soft.Release = "1.1.0v";

            Console.WriteLine(robot);
            Console.WriteLine(anotherRobot);

        }
    }
}
