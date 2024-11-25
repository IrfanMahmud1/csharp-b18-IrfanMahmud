using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class _1915A
    {
        public static void Result()
        {
            int t = int.Parse(Console.ReadLine());

            while (t > 0)
            {
                string[] input = Console.ReadLine().Split();
                int a = int.Parse(input[0]), b = int.Parse(input[1]), c = int.Parse(input[2]);
                if (a == b)
                {
                    Console.WriteLine(c);
                }
                else if (a == c)
                {
                    Console.WriteLine(b);
                }
                else
                {
                    Console.WriteLine(a);
                }
                t--;
            }

        }
    }
}
