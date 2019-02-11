using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiophanticEquation
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine(solEquaStr(900000005));
            Console.ReadKey();
        }

        public static string solEquaStr(long n)
        {
            long x = 0;
            long y = 0;
            List<string> solution = new List<string>();
            long sqrtN = (long)Math.Round(Math.Sqrt(n));

            List<long> factorList = new List<long>();
            factorList = Factor(n);
            //in a case there are odd number of factors.
            if (factorList.Count % 2 == 1)
            {
                factorList.Add(0);
            }

            for(int i=0; i< factorList.Count-1; i+=2)
            {
                //solving for x - 2y = factor 1 and x + 2y = factor 2
                double fac1 = factorList[i];
                double fac2 = factorList[i + 1];
                double tempY = 0;
                if (fac2 - fac1 > 0)//y cannot be less than 0
                {
                    tempY = Math.Abs((fac2 - fac1)) / 4;//because y = (factor2 - factor1)/4
                }
                if (tempY % 1 == 0)
                {
                    y = (long)tempY;
                    x = factorList[i] + 2 * y; //because x = factor1 + 2*y
                    solution.Add("[" + x.ToString() + ", " + y.ToString() + "], ");
                }
            }

            string result = "";
            //this is just formatting the final answer to the correct format.
            for (int i = 0; i < solution.Count; i++)
            {
                if (i == solution.Count -1)
                {
                    string str = "";
                    str = solution[i].Remove(solution[i].Length - 2);
                    solution.RemoveAt(i);
                    solution.Add(str);
                }
                result = result + solution[i].ToString();
            }


            return "[" + result +"]";
        }

        private static List<long> Factor(long number)
        {
            List<long> factors = new List<long>();
            int max = (int)Math.Sqrt(number);  //round down
            for (int factor = 1; factor <= max; ++factor)
            { //test from 1 to the square root, or the int below it, inclusive.
                if (number % factor == 0)
                {
                    factors.Add(factor);
                    if (factor != number / factor)
                    { // Don't add the square root twice!
                        factors.Add(number / factor);
                    }
                }
            }
            return factors;
        }
    }
}
