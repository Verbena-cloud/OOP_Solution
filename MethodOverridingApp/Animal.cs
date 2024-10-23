using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverridingApp
{
    public class Animal
    {
        public virtual void Speak()
        {
            Console.WriteLine("the animal can make sound");
        }

    }
    public class Dog : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("the dog barks");
        }
    }
    public class Cat : Animal
    {
        public override void  Speak()
        {
            Console.WriteLine("the cat meows");
        }

    }

}
