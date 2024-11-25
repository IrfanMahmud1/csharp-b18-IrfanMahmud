using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class _1472B
    {
        public static void Result()
        {
            int t = int.Parse(Console.ReadLine());
            while (t > 0)
            {
                Console.ReadLine();
                string[] input = Console.ReadLine().Split();
                int one = 0, two = 0;
                for (int i = 0; i < input.Length; i++)
                {
                    if (input[i] == "1")
                    {
                        one++;
                    }
                    else
                    {
                        two++;
                    }
                }
                int total = one + two * 2;
                if (one % 2 != 0 || total % 2 != 0)
                {
                    Console.WriteLine("No");
                }
                else if ((one % 2 != 0 && two % 2 != 0) || (two % 2 != 0 && one == 0))
                {
                    Console.WriteLine("No");
                }
                else
                {
                    Console.WriteLine("Yes");
                }
                t--;
            }

        }
    }
}
