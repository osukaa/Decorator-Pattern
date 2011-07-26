using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Decorator_Pattern.Component
{
    public class DarkRoast : Beverage
    {
        public DarkRoast()
        {
            description = "Dark roast coffee";
        }

        public override double cost()
        {
            return 0.99f;
        }
    }
}
