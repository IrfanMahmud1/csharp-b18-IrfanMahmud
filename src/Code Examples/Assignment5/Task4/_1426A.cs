using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class _1426A
    {
        public static void Result()
        {
            int t = int.Parse(Console.ReadLine());

            while (t > 0)
            {
                int[] ar = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                int ans = 0;
                if (ar[0] <= 2)
                {
                    ans = 1;
                }
                else
                {
                    ans = ((ar[0] - 3) / ar[1]) + 2;
                }
                Console.WriteLine(ans);
                t--;
            }

        }
    }
}
