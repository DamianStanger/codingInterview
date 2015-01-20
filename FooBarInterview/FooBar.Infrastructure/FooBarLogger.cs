using System;

namespace FooBar.Infrastructure
{
    public class FooBarLogger : IFooBarLogger
    {
        public void Log(string[] args)
        {
            Console.WriteLine("Logger Called :-)");
        }
    }
}