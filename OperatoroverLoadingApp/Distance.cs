using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatoroverLoadingApp
{
    public class Distance
    {
        public int Feet {  get; set; }
        public double Inches { get; set; }
        public Distance() { }
        public Distance ( int feet , double inches)
        {
            this.Feet = feet;
            this.Inches = inches;   
        }
        public override string ToString()
        {
            return $"{Feet}\' -{Inches}\" "; 
        }
       
        public static  Distance operator + ( Distance a, Distance b )
        //represent to( d1 + d2 )
        {
            Distance result = new Distance();
            result.Feet = a.Feet + b.Feet;
            result.Inches =a.Inches + b.Inches;
            if (result.Inches >= 12)
            {
                result.Inches -= 12;
                result.Feet++;

            }
            return result;
        }
        public  static Distance operator - (Distance a, Distance b )
        //represent to( d1 - d2 )
        {
            Distance result = new Distance();
            result.Feet = a.Feet + b.Feet;
            result.Inches = a.Inches + b.Inches;
            if (result.Inches < 0)
            {
                result.Inches += 12;
                result.Feet--;

            }
            return result;
        }
    }

}
