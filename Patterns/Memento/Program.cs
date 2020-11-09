using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;

namespace Memento
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            PlayerSaver saver = new PlayerSaver(player);

            player.Info();
            player.Attacking();
            player.Attacking();
            player.Attacking();
            player.Move(Direction.Up);
            player.Move(Direction.Up);
            player.Move(Direction.Left);
            player.Move(Direction.Left);
            player.Move(Direction.Up);
            player.Attacked(10);
            player.Info();

            saver.Save();

            player.Attacking();
            player.Attacking();
            player.Move(Direction.Down);
            player.Move(Direction.Right);
            player.Move(Direction.Down);
            player.Attacked(30);
            player.Info();
            saver.Undo();
            player.Info();
        }
    }
    
    class Player
    {
        public Coord Coord { get; set; } = new Coord();
        public int HP { get; set; } = 100;
        public int Stamnia { get; set; } = 100;

        public void Move(Direction direction)
        {
            switch (direction)
            {
                case Direction.Up:
                    Coord.Y++;
                    break;
                case Direction.Down:
                    Coord.Y--;
                    break;
                case Direction.Left:
                    Coord.X--;
                    break;
                case Direction.Right:
                    Coord.X++;
                    break;
            }
        }
        public void Attacked(int damage)
        {
            HP -= damage;
        }
        public void Attacking()
        {
            Stamnia -= 5;
        }
        public void Info()
        {
            Console.WriteLine($"Coordinates: {Coord.X} - {Coord.Y}");
            Console.WriteLine($"Health: {HP}");
            Console.WriteLine($"Stamnia: {Stamnia}");
            Console.WriteLine();
        }
    
        public PlayerMemento Save()
        {
            return new PlayerMemento(Coord.Clone() as Coord, HP, Stamnia);
        }
        public void Load(PlayerMemento memento)
        {
            Coord = memento.Coord;
            HP = memento.HP;
            Stamnia = memento.Stamnia;
        }
    }

    class PlayerSaver
    {
        private Player originator;
        private Stack<PlayerMemento> history = new Stack<PlayerMemento>();
        public PlayerSaver(Player originator)
        {
            this.originator = originator;
        }

        public void Save()
        {
            history.Push(originator.Save());
        }

        public void Undo()
        {
            originator.Load(history.Pop());
        }
    }

    class PlayerMemento
    {
        public PlayerMemento(Coord coord, int hP, int stamnia)
        {
            Coord = coord;
            HP = hP;
            Stamnia = stamnia;
        }

        public Coord Coord { get; set; }
        public int HP { get; set; }
        public int Stamnia { get; set; }
    }

    enum Direction
    {
        Up,Down,Left,Right
    }
    public class Coord : ICloneable
    {
        public int X { get; set; } = 0;
        public int Y { get; set; } = 0;

        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}
