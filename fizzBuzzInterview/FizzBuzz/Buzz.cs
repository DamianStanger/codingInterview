namespace FizzBuzz
{
    public class Buzz : INumberTester
    {
        public string GetReplacement(int number)
        {
            if (number % 5 == 0)
            {
                return "Buzz";
            }
            return "";
        }
    }
}