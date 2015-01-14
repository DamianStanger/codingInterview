using System;

namespace ConsoleApp
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            var fizzBuzzCalculator = new FizzBuzzCalculator();
            string fizzbuzz = fizzBuzzCalculator.CalculateFizzBuzz(1);
            Console.WriteLine(fizzbuzz);
        }
    }
}
