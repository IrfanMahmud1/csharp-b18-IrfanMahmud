using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class _1294A
    {
        public static void Result()
        {
            int t = int.Parse(Console.ReadLine());
            while (t > 0)
            {
                int[] input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                int mx = 0;
                for (int i = 0; i < input.Length - 1; i++)
                {
                    mx = input[i] > mx ? input[i] : mx;
                }
                input[3] -= (mx - input[0]) + (mx - input[1]) + (mx - input[2]);
                if (input[3] % 3 == 0 && input[3] >= 0)
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
