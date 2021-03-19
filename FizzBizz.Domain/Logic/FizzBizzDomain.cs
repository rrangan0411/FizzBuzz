using System.Collections.Generic;

namespace FizzBizz.Domain.Logic
{
    public class FizzBizzDomain: IFizzBizzDomain
    {
        public IEnumerable<string> EvalList(IEnumerable<object> val)
        {
            var result = new List<string>();

            foreach (var v in val)
            {
                if (double.TryParse(v?.ToString(), out double number))
                {
                    if (number % 3 == 0 && number % 5 == 0)
                    {
                        result.Add("FizzBuzz");
                    }
                    else if (number % 5 == 0)
                    {
                        result.Add("Buzz");
                    }
                    else if (number % 3 == 0)
                    {
                        result.Add("Fizz");
                    }
                    else
                    {
                        result.Add($"Divided {v} by 3");
                        result.Add($"Divided {v} by 5");
                    }
                }
                else
                {
                    result.Add("Invalid Item");
                }
            }

            return result;
        }
    }
}