namespace inherientApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog mydog =new Dog();
            mydog.Name = "Freedy";   //due to (public)
            mydog.Breed = "G R";
            mydog.MakeSound();
            //mydog.Fetch();            //due to partent(animal)

            //mydog.Eat();

            
        }
    }
}
