﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HasARelationShip
{
    public class Address
    {
        public string Street {  get; set; }
        public string City { get; set; }    
        public string Country { get; set; }

        public Address() { }
        public Address(string street, string city, string country)
        {
            Street = street;
            City = city;
            Country = country;          
        }
        public override string ToString()
        {
            return $"{Street}:{City}:{Country}";

        }
    }
}
