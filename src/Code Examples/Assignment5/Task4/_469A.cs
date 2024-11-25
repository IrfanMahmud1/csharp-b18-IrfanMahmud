using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class _469A
    {
        public static void Result()
        {
            /*
4
3 1 2 3
2 2 4

 */

            int t = int.Parse(Console.ReadLine());
            string[] input1 = Console.ReadLine().Split();
            string[] input2 = Console.ReadLine().Split();

            int p1 = input1.Length, p2 = input2.Length;
            int[] freq = new int[t + 1];
            int n = freq.Length;
            for (int i = 1; i < p1; i++)
            {
                freq[int.Parse(input1[i])]++;
            }
            for (int i = 1; i < p2; i++)
            {
                freq[int.Parse(input2[i])]++;
            }

            for (int i = 1; i < n; i++)
            {
                if (freq[i] == 0)
                {
                    Console.WriteLine("Oh, my keyboard!");
                    return;
                }
            }
            Console.WriteLine("I become the guy.");
        }
    }
}
