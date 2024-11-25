using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class _1551A
    {
        public static void Result()
        {
            int t = int.Parse(Console.ReadLine());

            while (t > 0)
            {
                int n = int.Parse(Console.ReadLine());
                if ((n % 3) % 2 == 0)
                {
                    Console.WriteLine(n / 3 + " " + (n / 3 + (n % 3) / 2));
                }
                else
                {
                    Console.WriteLine((n / 3 + n % 3) + " " + n / 3);
                }
                t--;
            }

        }
    }
}
