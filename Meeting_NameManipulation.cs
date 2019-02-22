using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meeting
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Result: {0}", Meeting("Alexis:Wahl;John:Bell;Victoria:Schwarz;Abba:Dorny;Grace:Meta;Ann:Arno;Madison:STAN;Alex:Cornwell;Lewis:Kern;Megan:Stan;Alex:Korn"));
            Console.ReadKey();
        }

        public static string Meeting(string s)
        {
            string result = "";
            List<string> lst = s.Split(';').ToList();
            string[] names = { };
            for (int i = 0; i < lst.Count; i++)
            {
                names = lst[i].Split(':');
                lst[i] = "(" + names[1].ToUpper() + ", " + names[0].ToUpper() + ")";
            }

            lst.Sort();

            result = string.Join("", lst.ToArray());

            return result;
        }
    }
}
