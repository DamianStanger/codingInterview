using System;
using FizzBuzz;

namespace ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var counter = int.Parse(args[0]);
            for (int i = 1; i <= counter; i++)
            {
                var f = Fizz.GetReplacement(i);
                var b = Buzz.GetReplacement(i);

                if (string.IsNullOrEmpty(f) && string.IsNullOrEmpty(b))
                {
                    Console.WriteLine(i);
                }
                else
                {
                    Console.WriteLine((f + " " + b).Trim());
                }
            }
        }

        static Program()
        {
            Fizz = new Fizz();
            Buzz = new Buzz();
        }

        public static INumberTester Fizz { get; set; }
        public static INumberTester Buzz { get; set; }
    }
}
