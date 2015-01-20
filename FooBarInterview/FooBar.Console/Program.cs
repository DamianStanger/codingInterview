using FooBar.Application;
using FooBar.Infrastructure;

namespace FooBar.Console
{
    static class Program
    {
        static void Main(string[] args)
        {
            var result = new FooBarGameRunner(new FooBarCalculator(), new FooBarLogger()).Run(args);

            System.Console.Out.WriteLine(result);
            System.Console.ReadKey();
        }
    }
}
