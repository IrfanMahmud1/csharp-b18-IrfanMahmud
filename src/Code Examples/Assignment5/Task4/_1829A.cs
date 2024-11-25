using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class _1829A
    {
        public static void Result()
        {
            int t = int.Parse(Console.ReadLine());

            while (t > 0)
            {
                string s = Console.ReadLine(), b = "codeforces";
                int ans = 0;
                for (int i = 0; i < 10; i++)
                {
                    if (s[i] != b[i])
                    {
                        ans++;
                    }
                }
                Console.WriteLine(ans);
                t--;
            }

        }
    }
}
