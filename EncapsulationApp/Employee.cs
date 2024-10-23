using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationApp
{
    public class Employee
    {
        private string name;
        private double salary;
        private string address;
        public string Name 
        { 
            get { return name; }
            set {  
                    if(!string.IsNullOrEmpty(value))
                    {
                        name = value;
                    }
                    else
                    {
                    // Console.WriteLine ("Name not empty or null");
                    throw new ArgumentException("Name not empty or null");
                    }
                }
        }   
        public double Salary
        {
            get { return salary; }
            set
            {
                if (value>=0)
                {
                    salary = value;
                }
                else
                {
                    throw new ArgumentException("not Negative");
                }
            }
        }
        public string Address
        {
            get { return address; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    address = value;    

                }
                else
                {
                    throw new ArgumentException("you dont have address");
                }
            }
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Employee: {Name} : {Salary} : {Address}");
        }
    }
}
