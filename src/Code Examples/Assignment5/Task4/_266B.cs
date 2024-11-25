using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class _266B
    {
        public static void Result()
        {
            string[] input1 = Console.ReadLine().Split(' ');
            int n = int.Parse(input1[0]), t = int.Parse(input1[1]);
            char[] input2 = Console.ReadLine().ToArray();

            while (t > 0)
            {
                for (int i = 0; i < n - 1; i++)
                {
                    if (input2[i] == 'B' && input2[i + 1] == 'G')
                    {
                        input2[i] = 'G';
                        input2[i + 1] = 'B';
                        i++;
                    }
                }
                t--;
            }
            foreach (char c in input2)
            {
                Console.Write(c);
            }

        }
    }
}
