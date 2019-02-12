using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RGBToHexConversion
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("result: " + Rgb(255, 255, 300));
            Console.ReadKey();

        }

        public static string Rgb(int r, int g, int b)
        {
            string result = "";
            List<int> rgb = new List<int>();
            rgb.Add(r);
            rgb.Add(g);
            rgb.Add(b);

            foreach(int i in rgb)
            {
                string temp1, temp2;
                //convert each integer into Hex and add to result
                if (i >= 0)
                {
                    if(i < 16)
                    {
                        temp1 = "0";
                    }
                    else if (i / 16 < 10)
                    {
                        temp1 = (i / 16).ToString();
                    }
                    else if (i / 16 > 15)
                    {
                        temp1 = Alphabet(15);
                    }
                    else
                    {
                        temp1 = Alphabet(i / 16);
                    }
                    if( i / 16 > 15)
                    {
                        temp2 = Alphabet(15);
                    }
                    else if (i % 16 < 10)
                    {
                        temp2 = (i % 16).ToString();
                    }
                    else if(i < 16) // single digit number
                    {
                        temp2 = (Alphabet(i));
                    }
                    else
                    {
                        temp2 = Alphabet(i % 16);
                    }
                    result += temp1 + temp2;
                }
                else
                {
                    result += "00";
                }
            }

            return result;
        }
        private static string Alphabet(int n)
        {
            switch (n)
            {
                case 10:
                    return "A";
                case 11:
                    return "B";
                case 12:
                    return "C";
                case 13:
                    return "D";
                case 14:
                    return "E";
                case 15:
                    return "F";
                default:
                    return n.ToString();

            }
        }

    }
}
