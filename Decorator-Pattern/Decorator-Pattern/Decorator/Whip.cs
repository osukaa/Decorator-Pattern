using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Decorator_Pattern.Component;

namespace Decorator_Pattern.Decorator
{
    public class Whip : CondimentDecorator
    {
        Beverage beverage;

        public Whip(Beverage beverage)
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
