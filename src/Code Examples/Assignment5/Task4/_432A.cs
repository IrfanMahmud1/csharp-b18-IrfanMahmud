using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class _432A
    {
        public static void Result()
        {
            string[] input1 = Console.ReadLine().Split();
            string[] input2 = Console.ReadLine().Split();

            int k = int.Parse(input1[1]);
            int cnt = 0;
            for (int i = 0; i < input2.Length; i++)
            {
                int student = int.Parse(input2[i]);
                if (student <= 5 - k)
                {
                    cnt++;
                }
            }
            Console.WriteLine(cnt / 3);
        }
    }
}
