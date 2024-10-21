namespace ConstructorApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Constructor");
            Car mycar = new Car("Toyotar", 2008);
            Console.WriteLine("my car: " + mycar);

            Car sis_car = new Car(mycar);           // data pl same (car ka two) 
            Console.WriteLine("sis_car: " + sis_car);
            //Car sis_car = mycar;                   //car is only one (assigned)
            //Console.WriteLine("sis_car: "+ sis_car);
        }
    }
}
