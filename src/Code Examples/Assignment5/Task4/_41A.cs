using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class _41A
    {
        public static void Result()
        {
            string input1 = Console.ReadLine();
            string input2 = Console.ReadLine();

            int m = input1.Length, n = input2.Length;
            if (m != n)
            {
                Console.WriteLine("NO");
                return;
            }
            for (int i = 0, j = n - 1; i < m; i++, j--)
            {
                if (input1[i] != input2[j])
                {
                    Console.WriteLine("NO");
                    return;
                }
            }
            Console.WriteLine("YES");


        }
    }
}
