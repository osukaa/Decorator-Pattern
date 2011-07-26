using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Decorator_Pattern.Component
{
    public class HouseBlend : Beverage
    {
        public HouseBlend()
        {
            description = "House blend coffee";
        }

        public override double cost()
        {
            return 0.89f;
        }
    }
}
