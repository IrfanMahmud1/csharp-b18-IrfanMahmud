using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class _732A
    {
        public static void Result()
        {
            string[] input = Console.ReadLine().Split();

            int a = int.Parse(input[0]), b = int.Parse(input[1]);
            int i = 1, ans = 0;

            while (true)
            {
                int v = i * a;
                if (v % 10 == b || v % 10 == 0 || v == b)
                {
                    ans = i;
                    break;
                }
                i++;
            }
            Console.WriteLine(ans);
        }
    }
}
