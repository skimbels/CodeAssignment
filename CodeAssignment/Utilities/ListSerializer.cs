using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace CodeAssignment.Utilities
{
    public class ListSerializer
    {
        public static List<int> Deserialize(string s, out string errorMessage)
        {
            List<int> numbers = new List<int>();
            errorMessage = string.Empty;

            s = s.Trim('[', ']');
            
            if (string.IsNullOrEmpty(s))
            {
                return numbers;
            }

            var numberStrings = s.Split(',');

            foreach (var numberString in numberStrings)
            {
                int number;
                if (int.TryParse(numberString.Trim(), out number))
                {
                    numbers.Add(number);
                }
                else {
                    errorMessage = $"Cannot parse input. Value '{numberString}' is not valid.";
                    return null;
                }
            }

            return numbers;
        }

        public static string Serialize(List<int> list)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append('[');

            for (int i = 0; i < list.Count; i++)
            {
                if (i > 0)
                {
                    sb.Append(",");
                }

                sb.Append(list[i]);
            }

            sb.Append(']');

            return sb.ToString();
        }
    }
}
