using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeAssignment.Utilities
{
    public class TriplicateCalulator
    {
        public static List<int> CalculateTriplicates(List<int> numbers)
        {
            List<int> triplicates = new List<int>();

            if (numbers.Count == 0)
            {
                return triplicates;
            }

            numbers = numbers.OrderByDescending(i => i).ToList();

            int counter = 0;
            int previousValue = numbers[0];
            foreach (int number in numbers)
            {
                if (number != previousValue)
                {
                    if (counter >= 3)
                    {
                        triplicates.Add(previousValue);
                    }
                    counter = 0;
                }
                counter++;
                previousValue = number;
            }

            if (counter >= 3)
            {
                triplicates.Add(previousValue);
            }

            return triplicates;
        }
    }
}
