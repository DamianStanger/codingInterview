using System;
using System.Collections.Generic;
using System.Linq;
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
                var replacement = NumberTesters.Aggregate("", (current, numberTester) => (current + (" " + numberTester.GetReplacement(i))).Trim());

                if (string.IsNullOrEmpty(replacement))
                {
                    Console.WriteLine(i);
                }
                else
                {
                    Console.WriteLine(replacement);
                }
            }
        }

        static Program()
        {
            NumberTesters = new List<INumberTester>()
            {
                new Fizz(), 
                new Buzz()
            };
        }

        public static IEnumerable<INumberTester> NumberTesters { get; set; } 
    }
}
