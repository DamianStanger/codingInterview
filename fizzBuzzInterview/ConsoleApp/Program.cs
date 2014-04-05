using System;

namespace ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var target = int.Parse(args[0]);
            var output = "";

            for (int i = 1; i <= target; i++)
            {
                string val;
                if (i % 3 == 0 && i % 5 == 0)
                {
                    val = "FizzBuzz";
                }
                else if (i%3==0)
                {
                    val = "Fizz";
                }
                else if (i % 5 == 0)
                {
                    val = "Buzz";
                }
                else
                {
                    val = i.ToString();
                }

                output += string.Format("{0} ", val);
            }
            Console.Write(output.Trim());
        }
    }
}
