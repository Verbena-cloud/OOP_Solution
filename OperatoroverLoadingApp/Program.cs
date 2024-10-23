namespace OperatoroverLoadingApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            a = 100; b = 500;
            Console.WriteLine(a + b);
            Distance d1 = new Distance(10,5);
            Distance d2 = new Distance(8, 9.5);

            Distance d3 = d1 - d2;  
            Console.WriteLine(d3);

            Distance d4 = d1 + d2;
            Console.WriteLine(d4);

            //Complex n1 = new Complex();
            //n1.Real = 5;
            //n1.Imaginary = 7;
            Complex n1 =new Complex { Real= 5 ,Imaginary= 7 };
            Complex n2 = new Complex { Real = 2, Imaginary = 9 };
            Complex n3 = n1 + n2;
            Console.WriteLine(n3.Real + n3.Imaginary);

        }
    }
}
