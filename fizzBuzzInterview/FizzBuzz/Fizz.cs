namespace FizzBuzz
{
    public class Fizz : INumberTester
    {
        public string GetReplacement(int number)
        {
            if (number % 3 == 0)
            {
                return "Fizz";
            }
            return "";
        }
    }
}