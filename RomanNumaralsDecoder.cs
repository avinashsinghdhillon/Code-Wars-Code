using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumeralsDecoder
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Result: " + Solution ("MDCLXVI").ToString());
            Console.ReadKey();
        }

        public static int Solution(string roman)
        {
            int result = 0;
            char[] chars = roman.ToUpper().ToCharArray();//ToUpper, incase any chars are lower case.
            List<int> nums = new List<int>();

            if (chars.Length > 0)
            {
                foreach (char c in chars)
                {
                    nums.Add(GetNumericVal(c));
                }
            }

            for (int i = 0; i < nums.Count; i++)
            {
                if (i == nums.Count - 1)//if on the last numeral
                {
                    result += nums[i];
                }
                else
                {
                    if (nums[i] >= nums[i + 1])//left numeral is larger or equal to the right numeral
                    {
                        result += nums[i];
                    }
                    else //when the left numeral is less than the right
                    {
                        result += nums[i + 1] - nums[i];
                        i++;
                    }
                }
            }

            return result;
        }

        private static int GetNumericVal(char romanN)
        {
            switch (romanN)
            {
                case 'I':
                    return 1;
                case 'V':
                    return 5;
                case 'X':
                    return 10;
                case 'L':
                    return 50;
                case 'C':
                    return 100;
                case 'D':
                    return 500;
                case 'M':
                    return 1000;
                default:
                    return 0;
            }
        }

    }
}
