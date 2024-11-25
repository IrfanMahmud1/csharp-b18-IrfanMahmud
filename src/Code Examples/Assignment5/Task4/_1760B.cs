using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class _1760B
    {
        public static void Result()
        {
            int t = int.Parse(Console.ReadLine());

            while (t > 0)
            {
                Console.ReadLine();
                string s = Console.ReadLine();
                int ans = 0;
                foreach (char c in s)
                {
                    ans = ans < c - 'a' + 1 ? c - 'a' + 1 : ans;
                }
                Console.WriteLine(ans);
                t--;
            }

        }
    }
}
