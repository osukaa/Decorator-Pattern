using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Decorator_Pattern.Test;

namespace Decorator_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            StarbuzzTest test = new StarbuzzTest();
            test.main();
            Console.ReadKey(true);
        }
    }
}
