using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatoroverLoadingApp
{
    public class Complex
    {
        public int Real { get; set; }
        public int Imaginary { get; set; }
        public static Complex operator +(Complex a, Complex b)
        {
            //Complex complex = new Complex();
            //complex.Real = a.Real + b.Real;
            //complex.Imaginary= a.Imaginary + b.Imaginary;
            //return complex;

            return new Complex
            {
                Real = a.Real + b.Real,
                Imaginary = a.Real * b.Imaginary,
            };

        }
    }
}
