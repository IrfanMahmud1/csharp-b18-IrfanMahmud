using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class _1360B
    {
        public static void Result()
        {
            int t = int.Parse(Console.ReadLine());
            while (t > 0)
            {
                int n = int.Parse(Console.ReadLine());
                int[] input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                Array.Sort(input);
                int mn = 100000;
                for (int i = n - 1; i > 0; i--)
                {
                    int v = input[i] - input[i - 1];
                    mn = v < mn ? v : mn;
                }
                Console.WriteLine(mn);
                t--;
            }

        }
    }
}
