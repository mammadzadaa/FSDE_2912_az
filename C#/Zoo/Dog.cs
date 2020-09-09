using System;

namespace Zoo
{

    class Test
    {
        static Dog dog = new Dog("", 1, "");
        static void Foo()
        {
           // dog.PrivateProtected    // No
           
            // dog.InternalProtected // Ok

           // dog.Internal; // OK
        }
    }
    public class Dog : Animal
    {
        public override string Name { get => base.Name; set => base.Name = value; }
        public Dog(string name, int age, string type) : base(name, age)
        {
            Type = type;
            // base.Private // Inacsessable
           // base.Protected // OK
           // base.Internal // OK
          // base.PrivateProtected // OK
        }

        public string Type { get; set; }

        // public new void Sound() => Console.WriteLine("barking! gaw gaw");

        public override void VSound()
        {
            Console.WriteLine(" gaw gaw");
        }

        public override string ToString()
        {
            return $"{base.ToString()} {Type}";
        }

        public override void Sound() => Console.WriteLine("barking! gaw gaw");

    }

}
