using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inherientApp
{
    public class Animal
    {
        public string Name { get; set; }

        public Animal() { Console.WriteLine($"{Name}default Constructor"); }  


        public Animal(string name)  //dog ko build yin animal ko build phat ya mr
        {
            Name = name;
            Console.WriteLine($"{Name}parameter Constructor");
        }
        public void Eat()
        {
            Console.WriteLine($"{Name} is eating ");
        }
       
        public virtual void MakeSound() //(hide)
        //nga yae child tway ko overriding tone kwit pyuu
        {
            Console.WriteLine("The animal make a sound");
        }                                                         

    }
    public class Dog : Animal
    //animal is parent and dog is their child  (can share to everywhere)
    {
        public string Breed { get; set; }
        //public Dog(string name, string breed) : base(name)
        ////( : )child class
        //{
        //    Breed = breed;
        //}

        public Dog() 
        {
            Console.WriteLine($"{Name} default Constructor");
        }
        public Dog(string name,string breed): base(name)
        {
            Breed = breed;
            Console.WriteLine($"{Breed} parameter constructor");
        }
        public override void MakeSound()
        {
            base.MakeSound();
            //up mr shi tae (makesound)ko recall 
            Console.WriteLine($"{Name} is Braking");
        }
        public void Fetch()
        {
            Console.WriteLine($"{Name} is fetching the ball");
        }
        public override string ToString()
        {
            return $"{Name}-{Breed}"; 
        }
    }

}

