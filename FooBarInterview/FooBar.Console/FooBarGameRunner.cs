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

        public void Run(string[] args)
        {
            int start = int.Parse(args[0]);
            int end = int.Parse(args[1]);

            var result = _fooBarCalculator.Calculate(start, end);

            System.Console.Out.WriteLine(result);
        }
    }
}