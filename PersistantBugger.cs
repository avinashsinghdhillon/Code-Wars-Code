using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersistentBugger
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Result: " + Persistence(999));
            Console.ReadKey();
        }
        public static int Persistence(long n)
        {
            int cnt = 0;
            int result = 1;
            List<int> dList = new List<int>();
            dList = addDigits(n);

            while (dList.Count > 1)
            {
                cnt++;
                result = 1;
                foreach (int i in dList)
                {
                    result = result * i;
                }
                dList.Clear();
                dList = addDigits(result);
            }

            return cnt;
        }

        public static List<int> addDigits(long num)
        {
            List<int> lst = new List<int>();
            while (num > 0)
            {
                lst.Add((int)(num % 10));
                num = num / 10;
            }
            return lst;
        }
    }
}
