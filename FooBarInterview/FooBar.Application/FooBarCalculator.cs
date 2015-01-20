namespace FooBar.Application
{
    public class FooBarCalculator
    {
        public virtual string Calculate(int start, int end)
        {
            var result = string.Empty;

            for (var i = start; i <= end; i++)
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