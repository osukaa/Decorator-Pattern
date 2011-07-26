using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Decorator_Pattern.Component;

namespace Decorator_Pattern.Decorator
{
    public class Mocha : CondimentDecorator
    {
        Beverage beverage;

        public Mocha(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public String getDescription()
        {
            return beverage.getDescription() + ", Mocha";
        }

        public override double cost()
        {
            return 0.20f + beverage.cost();
        }
    }
}
