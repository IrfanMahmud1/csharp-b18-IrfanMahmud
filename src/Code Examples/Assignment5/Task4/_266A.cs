using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class _266A
    {
        public static void Result()
        {
            int n = int.Parse(Console.ReadLine().Trim());
            string s = Console.ReadLine().Trim();
            int ans = 0;
            for (int i = 0; i < n - 1; i++)
            {
                if (s[i] == s[i + 1])
                {
                    ans++;
                }
            }

            Console.WriteLine(ans);

        }
    }
}
