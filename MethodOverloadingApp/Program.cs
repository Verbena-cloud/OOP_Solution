namespace MethodOverloadingApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
          Calculator calculator = new Calculator();
            Console.WriteLine(calculator.Add(12 , 18567));
            Console.WriteLine(calculator.Add(10,2,5));
            Console.WriteLine(calculator.Add(12.5,7.5));
        }
    }
}
