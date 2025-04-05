using System;
using System.Globalization;
using _2task.Interfaces;

namespace _2task.Printers
{
    public class EuropeanDatePrinter : IDatePrinter
    {
        public string PrintDate()
        {
            CultureInfo culture = new CultureInfo("ru-RU");
            return DateTime.Now.ToString("dd.MM.yyyy HH:mm", culture);
        }
    }
}
