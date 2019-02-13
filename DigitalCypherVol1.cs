using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalCypherVol1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Result: " + Encode("scout", 1939));
            Console.ReadKey();
        }
        public static int[] Encode(string str, int n)
        {
            char[] msg = str.ToUpper().ToCharArray();
            char[] key = n.ToString().ToCharArray();
            List<int> code = new List<int>();
            for(int i = 0; i <= msg.Length - 1; i++)
            {
                if (i <= key.Length - 1)
                {
                    code.Add(getDigitsForLetters(msg[i].ToString()) + int.Parse(key[i].ToString()));
                }
                else
                {
                    code.Add(getDigitsForLetters(msg[i].ToString()) + int.Parse(key[i % key.Length].ToString()));
                }
            }

            return code.ToArray();
        }

        public static int getDigitsForLetters(string c)
        {
            switch (c)
            {
                case "A":
                    return 1;
                case "B":
                    return 2;
                case "C":
                    return 3;
                case "D":
                    return 4;
                case "E":
                    return 5;
                case "F":
                    return 6;
                case "G":
                    return 7;
                case "H":
                    return 8;
                case "I":
                    return 9;
                case "J":
                    return 10;
                case "K":
                    return 11;
                case "L":
                    return 12;
                case "M":
                    return 13;
                case "N":
                    return 14;
                case "O":
                    return 15;
                case "P":
                    return 16;
                case "Q":
                    return 17;
                case "R":
                    return 18;
                case "S":
                    return 19;
                case "T":
                    return 20;
                case "U":
                    return 21;
                case "V":
                    return 22;
                case "W":
                    return 23;
                case "X":
                    return 24;
                case "Y":
                    return 25;
                case "Z":
                    return 26;
                default:
                    return 0;
            }
        }

    }
}
