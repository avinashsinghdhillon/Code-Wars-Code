using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendOrFoe
{
    class Program
    {
        static void Main()
        {
            string[] names = { "Ryan", "Kieran", "Mark", "Jimmy" };
            Console.WriteLine("Name: " + string.Join(",", FriendOrFoe(names)));
            Console.ReadKey();
        }
        public static string[] FriendOrFoe(string[] names)
        {
            // This code is not working in the app
            //IEnumerable<string> res = names.Where(name => (int)names.Length == 4);
            //return res;

            List<string> answer = new List<string>();
            foreach (string s in names)
            {
                if ((int)(s.ToCharArray()).Length == 4)
                {
                    answer.Add(s);
                }
            }

            
            return answer.ToArray();
        }
    }
}
