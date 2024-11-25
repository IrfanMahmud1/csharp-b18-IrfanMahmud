using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class _731A
    {
        public static void Result()
        {
            string s = Console.ReadLine();

            int ans = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (i == 0)
                {
                    ans += s[i] >= 'n' ? ('z' - s[i] + 1) : s[i] - 'a';
                }
                else if (s[i] >= 'a' && s[i] <= 'm')
                {
                    ans += s[i - 1] >= 'n'
                        ? ('z' - s[i - 1] + 1) + (s[i] - 'a')
                        : (s[i - 1] - s[i]) < 0 ? (s[i] - s[i - 1]) : (s[i - 1] - s[i]);
                }
                else
                {
                    ans += s[i - 1] <= 'm'
                       ? ('z' - s[i] + 1) + (s[i - 1] - 'a')
                       : (s[i] - s[i - 1]) < 0 ? (s[i - 1] - s[i]) : (s[i] - s[i - 1]);
                }
            }

            Console.WriteLine(ans);
        }
    }
}
