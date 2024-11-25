using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class _791A
    {
        public static void Result()
        {
            string[] input = Console.ReadLine().Split(' ');

            int a = int.Parse(input[0]);
            int b = int.Parse(input[1]);
            int ans = 0;
            while (a <= b)
            {
                a *= 3;
                b *= 2;
                ans++;
            }
            Console.WriteLine(ans);

        }
    }
}
