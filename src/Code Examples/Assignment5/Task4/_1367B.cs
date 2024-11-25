using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    public class _1367B
    {
        public static void Result()
        {
            var t = int.Parse(Console.ReadLine());

            while (t > 0)
            {
                var n = int.Parse(Console.ReadLine());
                var input = Console.ReadLine().Split(' ');
                var ar = new int[n];
                var cnt = 0;
                var even = 0;
                var odd = 0;
                for (int i = 0; i < n; i++)
                {
                    ar[i] = int.Parse(input[i]);
                    if (ar[i] % 2 == 0 && i % 2 == 0 || ar[i] % 2 != 0 && i % 2 != 0)
                    {
                        cnt++;
                    }
                    if (ar[i] % 2 == 0)
                    {
                        even++;
                    }
                    else
                    {
                        odd++;
                    }
                }
                if (even == odd || even - 1 == odd)
                {
                    Console.WriteLine((n - cnt) / 2);
                }
                else
                {
                    Console.WriteLine(-1);
                }
                t--;
            }

        }
    }
}
