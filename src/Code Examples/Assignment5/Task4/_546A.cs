using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class _546A
    {
        public static void Result()
        {
            string[] input = Console.ReadLine().Split(' ');

            int n = int.Parse(input[2]), k = int.Parse(input[0]), w = int.Parse(input[1]);
            // 1 2 1
            int sum = 0;
            while (n > 0)
            {
                sum += n * k;
                n--;
            }
            sum = sum < w ? 0 : sum - w;
            Console.WriteLine(sum);


        }
    }
}
