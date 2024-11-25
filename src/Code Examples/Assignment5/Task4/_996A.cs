using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class _996A
    {
        public static void Result()
        {
            int n = int.Parse(Console.ReadLine());
            int ans = 0;
            while (n != 0)
            {
                if (n >= 100)
                {
                    n -= 100;
                    ans++;
                }
                else if (n >= 20)
                {
                    n -= 20;
                    ans++;
                }
                else if (n >= 10)
                {
                    n -= 10;
                    ans++;
                }
                else if (n >= 5)
                {
                    n -= 5;
                    ans++;
                }
                else
                {
                    n -= 1;
                    ans++;
                }
            }

            Console.WriteLine(ans);

        }
    }
}
