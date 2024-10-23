namespace MethodOverridingApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            dog.Speak();
            Cat cat = new Cat();
            cat.Speak();    

            KBZ kbzbank = new KBZ(); 
            AYA ayabank = new AYA();
            
            Console.WriteLine("KBZ interest rate: " + kbzbank.GetInterestRate());
            Console.WriteLine("AYA interest rate: " + ayabank.GetInterestRate());


        }
    }
}
