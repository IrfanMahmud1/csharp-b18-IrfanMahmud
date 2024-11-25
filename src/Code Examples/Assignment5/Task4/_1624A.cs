using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class _1624A
    {
        public static void Result()
        {
            int t = int.Parse(Console.ReadLine());
            while (t > 0)
            {
                int n = int.Parse(Console.ReadLine());

                int[] input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                Array.Sort(input);
                Console.WriteLine(input[input.Length - 1] - input[0]);
                t--;
            }

        }
    }
}
