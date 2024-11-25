using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class _1971A
    {
        public static void Result()
        {
            int t = int.Parse(Console.ReadLine());
            while (t > 0)
            {
                string s = Console.ReadLine();
                int a = s[0] - '0', b = s[2] - '0';
                int mn = a < b ? a : b;
                int mx = a > b ? a : b;
                Console.WriteLine(mn + " " + mx);
                t--;
            }

        }
    }
}
