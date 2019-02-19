using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        
        static void Main()
        {
            long numb = 123123;
            Number num = new Number();
            Console.WriteLine("Number: " + numb + ", Digital Root: " + num.DigitalRoot(numb).ToString());
            Console.ReadKey();
        }

        
    }
    public class Number
    {
        public int DigitalRoot(long n)
        {
            return (int)(1 + (n - 1) % 9);
        }
    }
}
