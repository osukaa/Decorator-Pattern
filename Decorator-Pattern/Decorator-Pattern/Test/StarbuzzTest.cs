using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Decorator_Pattern.Component;
using Decorator_Pattern.Decorator;

namespace Decorator_Pattern.Test
{
    public class StarbuzzTest
    {
        public void main()
        {
            Beverage beverage = new Espresso();
            Console.WriteLine(beverage.getDescription() + " $ " + beverage.cost().ToString());

            Beverage beverage2 = new DarkRoast();
            beverage2 = new Mocha(beverage2);
            beverage2 = new Mocha(beverage2);
            beverage2 = new Whip(beverage2);
            Console.WriteLine(beverage2.getDescription() + " $ " + beverage2.cost().ToString());

            Beverage beverage3 = new HouseBlend();
            beverage3 = new Milk(beverage3);
            beverage3 = new Mocha(beverage3);
            beverage3 = new Soy(beverage3);
            Console.WriteLine(beverage3.getDescription() + " $ " + beverage3.cost().ToString());
        }
    }
}
