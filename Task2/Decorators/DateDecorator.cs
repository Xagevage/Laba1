using _2task.Interfaces;

namespace _2task.Decorators
{
    public abstract class DateDecorator : IDatePrinter
    {
        protected IDatePrinter _datePrinter;

        public DateDecorator(IDatePrinter datePrinter)
        {
            _datePrinter = datePrinter;
        }

        public virtual string PrintDate()
        {
            return _datePrinter.PrintDate();
        }
    }
}
