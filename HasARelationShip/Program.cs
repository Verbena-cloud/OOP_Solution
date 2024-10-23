namespace HasARelationShip
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Address agust= new Address("Insein Road", "ygn", "MM");
           Console.WriteLine(agust);

            // Address address1 = new Address("Pyay Road","ygn","MM"); 
            Employee e1 = new Employee("AAA", new Address("Pyay Road", "ygn", "MM"));

            e1.EmployeeAddress.City = "Mayagone";
            Console.WriteLine("e1 info: "+ e1);
           
        }
    }
}
