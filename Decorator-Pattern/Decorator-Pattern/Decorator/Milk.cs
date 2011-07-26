using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Decorator_Pattern.Component;

namespace Decorator_Pattern.Decorator
{
    public class Milk : CondimentDecorator
    {
        Beverage beverage;

        public Milk(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override String getDescription()
        {
            return beverage.getDescription() + ", Milk";
        }

        public override double cost()
        {
            return 0.20f + beverage.cost();
        }
    }
}
