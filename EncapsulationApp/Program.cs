namespace EncapsulationApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.Name = "AAA";
            employee.Salary = 50000;
            employee.Address = "Yangon";
            employee.DisplayInfo();

            Console.WriteLine("other tasks....");
        }
    }
}
