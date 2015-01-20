using FooBar.Application;

namespace FooBar.Console
{
    static class Program
    {
        static void Main(string[] args)
        {
            new FooBarGameRunner(new FooBarCalculator()).Run(args);
            System.Console.ReadKey();
        }
    }
}
