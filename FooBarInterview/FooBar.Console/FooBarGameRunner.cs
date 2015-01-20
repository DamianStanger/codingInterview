using FooBar.Application;

namespace FooBar.Console
{
    public class FooBarGameRunner
    {
        private readonly FooBarCalculator _fooBarCalculator;

        public FooBarGameRunner(FooBarCalculator fooBarCalculator)
        {
            _fooBarCalculator = fooBarCalculator;
        }

        public string Run(string[] args)
        {
            int start;
            int end;

            if (args.Length!=2)
            {
                return string.Format("'' Is not valid. Please enter two numbers between 0 and 100");
            }
            if (!int.TryParse(args[0], out start) | !int.TryParse(args[1], out end) || start < 1 || end < 1 || start > 100 || end > 100)
            {
                return string.Format("'{0} {1}' Is not valid. Please enter two numbers between 0 and 100", args[0], args[1]);
            }

            return _fooBarCalculator.Calculate(start, end);
        }
    }
}