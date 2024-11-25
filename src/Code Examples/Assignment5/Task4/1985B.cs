using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class _1985B
    {
        public static void Result()
        {
            int t = int.Parse(Console.ReadLine());
            while (t > 0)
            {
                int n = int.Parse(Console.ReadLine());
                int mx = 0, ans = 0;
                for (int i = 2; i <= n; i++)
                {
                    if (n / i >= mx)
                    {
                        mx = n / i;
                        ans = i;
                    }
                }
                Console.WriteLine(ans);
                t--;
            }

        }
    }
}
