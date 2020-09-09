using System;

namespace Zoo
{

    /*sealed*/
    public abstract class Animal // internal
    {
        public Animal(string name, int age)
        {
            Name = name;
            Age = age;
        }

        private int Private { get; set; }
        protected int Protected { get; set; }
        internal int Internal { get; set; }

        internal protected int InternalProtected { get; set; } // public for the same proj // protected outside
        private protected int PrivateProtected { get; set; }  // protected for the same proj // private outside



        public virtual string Name { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return $"{Name} {Age}";
        }

        abstract public void Sound();

        public virtual void VSound()
        {
            Console.WriteLine("Hmmmm");
        }
    }

}
