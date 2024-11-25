using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class _1772A
    {
        public static void Result()
        {
            int t = int.Parse(Console.ReadLine());

            while (t > 0)
            {
                int[] ar = Array.ConvertAll(Console.ReadLine().Split('+'), int.Parse);
                Console.WriteLine(ar[0] + ar[1]);
                t--;
            }

        }
    }
}
