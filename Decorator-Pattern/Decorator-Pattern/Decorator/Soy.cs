using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Decorator_Pattern.Component;

namespace Decorator_Pattern.Decorator
{
    public class Soy : CondimentDecorator
    {
        Beverage beverage;

        public Soy(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override String getDescription()
        {
            return beverage.getDescription() + ", Soy";
        }

        public override double cost()
        {
            return 0.2f + beverage.cost();
        }
    }
}
