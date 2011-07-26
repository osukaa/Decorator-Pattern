using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Decorator_Pattern.Component
{
    public class Decaf : Beverage
    {
        public Decaf()
        {
            description = "decaf coffee";
        }

        public override double cost()
        {
            return 2.5f;
        }
    }
}
