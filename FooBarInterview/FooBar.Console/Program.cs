using FooBar.Application;

namespace FooBar.Console
{
    static class Program
    {
        static void Main(string[] args)
        {
            var result = new FooBarGameRunner(new FooBarCalculator()).Run(args);

            System.Console.Out.WriteLine(result);
            System.Console.ReadKey();
        }
    }
}
