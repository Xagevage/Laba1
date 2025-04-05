using System;
using System.Globalization;
using _2task.Interfaces;

namespace _2task.Printers
{
    public class AmericanDatePrinter : IDatePrinter
    {
        public string PrintDate()
        {
            CultureInfo culture = new CultureInfo("en-US");
            return DateTime.Now.ToString("MM/dd/yyyy hh:mm tt", culture);
        }
    }
}
