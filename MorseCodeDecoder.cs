using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorseCodeDecoder_1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Text: " + Decode("···· · −·−−   ·−−− ··− −·· ·"));
            Console.ReadKey();

        }
        public static string Decode(string morseCode)
        {
            //First trim any blank spaces in the start or end of string
            morseCode.Trim();

            //split the string based on three spaces that seperate words
            string[] delimiter = { "   " };
            string[] text = morseCode.Split(delimiter, System.StringSplitOptions.None);
            string returnText = "";
            foreach (string s in text)
            {
                //now get the individual characters to create words
                string newWord = "";
                Char[] delim = { ' ' };
                string[] returnLetter = s.Split(delim, System.StringSplitOptions.None);
                foreach (string str in returnLetter)
                {
                    newWord = newWord + str;
                }

                returnText = returnText + newWord + " ";
            }
            return returnText.Trim();
        }
    }
}
;