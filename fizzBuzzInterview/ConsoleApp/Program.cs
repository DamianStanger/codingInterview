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
                output += string.Format("{0} ", i);
            }
            Console.Write(output.Trim());
        }
    }
}
