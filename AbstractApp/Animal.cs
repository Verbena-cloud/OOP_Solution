using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractApp
{
    public abstract class Animal
    {
        public string Name {  get; set; }

        public abstract void MakeSound();
        public void Sleep()
        {
            Console.WriteLine($"{Name} is sleeping");
        }
    }
    public class Dog : Animal

    {
        public override void MakeSound()
        {
            Console.WriteLine($"{Name} is barking");
        }
        public void Bark()
        {
            Console.WriteLine($"{Name} is barking");
        }
    }

    public class Cat : Animal

    {
        public override void MakeSound()
        {
            Console.WriteLine($"{Name} is Meow Meow");
        }
        public void Meou()
        {
            Console.WriteLine($"{Name} is Meow Meow");
        }
    }

}
