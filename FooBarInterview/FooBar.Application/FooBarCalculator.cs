namespace FooBar.Application
{
    public class FooBarCalculator
    {
        public string Calculate()
        {
            var result = string.Empty;

            for (var i = 1; i <= 10; i++)
            {
                if (i%3==0)
                {
                    result += "Foo";
                }
                else if (i % 5 == 0)
                {
                    result += "Bar";
                }
                else
                {
                    result += i.ToString();
                }
                result += " ";
            }

            return result.Trim();
        }
    }
}