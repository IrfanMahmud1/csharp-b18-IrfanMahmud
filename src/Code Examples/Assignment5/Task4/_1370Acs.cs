using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class _1370Acs
    {
        public static void Result()
        {
            int t = int.Parse(Console.ReadLine());

            while (t > 0)
            {
                int n = int.Parse(Console.ReadLine());
                int ans = 1;
                if (n % 2 == 0)
                {
                    ans = n / 2;
                }
                else
                {
                    ans = (n - 1) / 2;
                }
                Console.WriteLine(ans);
                t--;
            }

        }
    }
}
