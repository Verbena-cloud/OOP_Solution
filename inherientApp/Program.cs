namespace inherientApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
           /* Dog mydog =new Dog();
            mydog.Name = "Freedy";   //due to (public)
            mydog.Breed = "G R";
            mydog.MakeSound();
            //mydog.Fetch();            //due to partent(animal)

            //mydog.Eat();    */

            //Animal a=new Animal();
            //a.Name = "AAA";
            //a.Eat();
            //a.MakeSound();
            //Console.WriteLine(a.Name);

            Dog dog = new Dog();

            Dog dog2 = new Dog("Freedy","ok nar sar");
            Dog dog3 = new Dog("aye aye", "ok nar sar 2");

            Console.WriteLine(dog);
            Console.WriteLine(dog2);    
            Console.WriteLine(dog3);    
        }
    }
}
