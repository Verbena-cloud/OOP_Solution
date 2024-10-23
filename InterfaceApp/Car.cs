using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceApp
{
    public class Car : IVechicle, IEngine
    {
        public void Drive()
        {
            Console.WriteLine("The car is driving");
        }

        public void Engine()
        {
            Console.WriteLine("The car is hp engine");
        }

        public void Refue(int amount)
        {
            Console.WriteLine($"The car refueled {amount} liters");
        }
    }
}
