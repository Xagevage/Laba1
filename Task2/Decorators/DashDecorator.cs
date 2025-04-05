using System.Text;
using _2task.Interfaces;

namespace _2task.Decorators
{
    public class DashDecorator : DateDecorator
    {
        public DashDecorator(IDatePrinter datePrinter) : base(datePrinter) { }

        public override string PrintDate()
        {
            var sb = new StringBuilder();
            sb.Append("--- ");
            sb.Append(_datePrinter.PrintDate());
            sb.Append(" ---");
            return sb.ToString();
        }
    }
}
