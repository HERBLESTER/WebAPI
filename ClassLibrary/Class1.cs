using System;
using System.Collections.Generic;
using System.Linq;

namespace ClassLibrary
{
    public interface FizzBuzz
    {
        IEnumerable<string> GetFizzBuzz();
        string GetFizzBuzzNthelement(int index);
    }
    public class Class1 : FizzBuzz
    {
        public IEnumerable<string> GetFizzBuzz()
        {
            List<string> values = new List<string>(100);

            for (int i = 1; i <= 100; i++)
            {
                if ((i % 3 == 0) && (i % 5 == 0))
                {
                    values.Add("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    values.Add("Fizz");
                }
                else if (i % 5 == 0)
                {
                    values.Add("Buzz");
                }
                else
                {
                    values.Add(i.ToString());
                }
            }

            return values;
        }

        public string GetFizzBuzzNthelement(int index)
        {
            var values = GetFizzBuzz();

            return values.ToArray()[index - 1];
        }
    }
}
