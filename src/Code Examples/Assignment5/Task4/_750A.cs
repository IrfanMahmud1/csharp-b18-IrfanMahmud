using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class _750A
    {
        public static void Result()
        {
            string[] input = Console.ReadLine().Split(' ');

            int n = int.Parse(input[0]);
            int cnt = 5 * n * (n + 1) / 2;
            int t = int.Parse(input[1]);
            while (n > 0)
            {
                if (cnt + t <= 240)
                {
                    break;
                }
                cnt -= n * 5;
                n--;
            }
            Console.WriteLine(n);

        }
    }
}
