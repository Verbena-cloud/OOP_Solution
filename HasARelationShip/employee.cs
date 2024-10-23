using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HasARelationShip
{
    public class Employee
    {
        public string Name { get; set; }    
        public Address EmployeeAddress { get; set; }    
        public Employee(string name ,Address employeeAddress)
        {
            Name = name;
            EmployeeAddress = employeeAddress;
        }
        public override string ToString()
        {
            return Name+" "+EmployeeAddress.ToString(); 
        }
    }
}
