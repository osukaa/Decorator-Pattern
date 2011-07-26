using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Decorator_Pattern.Component
{
    public abstract class Beverage
    {
        public String description = "Unkwown beverage";

        public String getDescription()
        {
            return description;
        }

        public abstract double cost();
    }
}
