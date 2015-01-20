using FooBar.Application;

namespace FooBar.Console
{
    public class FooBarGameRunner
    {
        public void Run()
        {
            var result = new FooBarCalculator().Calculate();
            System.Console.Out.WriteLine(result);
            System.Console.ReadKey();
        }
    }
}