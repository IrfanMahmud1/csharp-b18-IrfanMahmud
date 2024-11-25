using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class _1535A
    {
        public static void Result()
        {
            int t = int.Parse(Console.ReadLine());
            while (t > 0)
            {
                string[] input = Console.ReadLine().Split();
                int a = int.Parse(input[0]), b = int.Parse(input[1]), c = int.Parse(input[2]),
                    d = int.Parse(input[3]);
                int fmx = a > b ? a : b, smx = c > d ? c : d;
                if ((fmx > c || fmx > d) && (smx > a || smx > b))
                {
                    Console.WriteLine("YES");
                }
                else
                {
                    Console.WriteLine("NO");
                }
                t--;
            }


        }
    }
}
