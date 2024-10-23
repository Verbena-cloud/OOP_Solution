using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceApp
{
    public class Motorcycle : IVechicle
    {
        public void Drive()
        {
            Console.WriteLine("The motorcycle is driving");
        }

        public void Refue(int amount)
        {
            Console.WriteLine($"The motorcycle refueled {amount} liters");
        }
    }
}
