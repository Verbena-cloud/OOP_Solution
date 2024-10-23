using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hasarelationshipapp2
{
    public class Person
    {
        public string Name { get; set; }
        public Address PersonAddress { get; set; }
        public Person(string name, Address address)
        {
            Name = name;
            PersonAddress = address;
        }
        public void DisplayPersonInfo()
        {
            Console.WriteLine($"Name: {Name}");
            PersonAddress.DisplayAddress();
        }
    }
}
