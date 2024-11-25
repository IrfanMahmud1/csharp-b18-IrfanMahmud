using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class _1154A
    {
        public static void Result()
        {
            string[] input = Console.ReadLine().Split();
            int[] freq = new int[3];
            int mx = -1, pos = -1;

            for (int i = 0; i < input.Length; i++)
            {
                int v = int.Parse(input[i]);
                if (v > mx)
                {
                    mx = v;
                    pos = i;
                }
            }
            int j = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (i != pos)
                {
                    int v = int.Parse(input[i]);
                    Console.WriteLine(mx - v);
                }
            }
        }
    }
}
