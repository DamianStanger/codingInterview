using FizzBuzz;

namespace ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Fizz.GetReplacement(1);
            Buzz.GetReplacement(1);
        }

        public static INumberTester Fizz { get; set; }
        public static INumberTester Buzz { get; set; }
    }
}
