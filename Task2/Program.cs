using System;
using _2task.Interfaces;
using _2task.Printers;
using _2task.Decorators;

namespace _2task
{
    class Program
    {
        static void Main()
        {
            IDatePrinter european = new StarDecorator(new DashDecorator(new EuropeanDatePrinter()));
            Console.WriteLine(european.PrintDate());

            IDatePrinter american = new DashDecorator(new StarDecorator(new AmericanDatePrinter()));
            Console.WriteLine(american.PrintDate());
        }
    }
}
