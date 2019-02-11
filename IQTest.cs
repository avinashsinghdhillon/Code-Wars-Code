using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IQTest
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine(Test("1 2 2"));
            Console.ReadKey();
        }
        public static int Test(string numbers)
        {
            int oddCnt = 0;
            int oddLoc = 0;
            int evenLoc = 0;
            int evenCnt = 0;
            string[] cDigits = numbers.Split(' ');

            for (int i = 0; i < cDigits.Length; i++)
            {
                if (int.Parse(cDigits[i].ToString()) % 2 == 0)
                {
                    evenCnt++;
                    evenLoc = i + 1;
                    
                }
                else
                {
                    oddCnt++;
                    oddLoc = i + 1;
                }

            }
            if (evenCnt > oddCnt)
                return oddLoc;
            else
                return evenLoc;
        }
    }
}
