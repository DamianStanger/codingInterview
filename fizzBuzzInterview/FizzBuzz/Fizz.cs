namespace FizzBuzz
{
    public class Fizz : INumberTester
    {
        public string GetReplacement(int number)
        {
            return number.ToString();
        }
    }
}