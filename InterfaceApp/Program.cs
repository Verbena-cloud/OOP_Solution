namespace InterfaceApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
           IVechicle car = new Car();
            car.Refue(10);
            car.Drive();

            IEngine engine = new Car();
            engine.Engine();

            IVechicle motorcycle = new Motorcycle();
            motorcycle.Refue(10);
            motorcycle.Drive();

            Car mycar = new Car();  
            mycar.Refue(10);
            mycar.Drive();
            mycar.Engine();


        }
    }
}
