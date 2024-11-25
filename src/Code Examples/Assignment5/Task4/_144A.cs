using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class _144A
    {
        public static void Result()
        {
            int n = int.Parse(Console.ReadLine());
            string[] input = Console.ReadLine().Split(' ');

            int mx = -1, mn = int.MaxValue, len = input.Length;
            int[] index = new int[2];
            for (int i = 0, j = len - 1; i < len; i++, j--)
            {
                int v = int.Parse(input[i]);
                if (v > mx)
                {
                    mx = v;
                    index[0] = i;
                }
                int k = int.Parse(input[j]);
                if (k < mn)
                {
                    mn = k;
                    index[1] = j;
                }
            }
            int ans = index[0] + input.Length - 1 - index[1];
            ans = index[0] > index[1] ? ans - 1 : ans;
            Console.WriteLine(ans);
        }
    }
}
