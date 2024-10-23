using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverridingApp
{
    public  class Bank
    {
        public virtual double GetInterestRate()
        {
            return 1.5;
        }
    }
    public  class KBZ : Bank
    {
        public override double GetInterestRate()
        {
            return base.GetInterestRate() + 7.5;
        }
    }
    public class AYA : Bank
    {
        public override double GetInterestRate()
        {
            return base.GetInterestRate()*3;
        }
    }



}
