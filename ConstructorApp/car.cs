using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorApp
{
    internal class Car
    {
        public string Brand {  get; set; }  
        public int Year { get; set; }
        public Car()
        {
            Brand = "unknown";
            Year = 0;
        }
        //parameter write Constructor
        public Car(string brand , int year) { Brand = brand;     
            Year = year;
        }    
        //copy Constructor
        public Car(Car car)
        {
            Brand = car.Brand;
            Year =car.Year;
        }
       public override string ToString()
        {
            return $"{Brand} - {Year}"; 
        }
    }
}
