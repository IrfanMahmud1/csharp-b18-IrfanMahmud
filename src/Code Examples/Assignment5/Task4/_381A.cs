using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class _381A
    {
        public static void Result()
        {
            int n = int.Parse(Console.ReadLine());
            string[] input = Console.ReadLine().Split();

            bool sereja = false, deema = false;
            int s = 0, d = 0;
            for (int i = 0, j = input.Length - 1; i <= j;)
            {
                int a = int.Parse(input[i]), b = int.Parse(input[j]);
                if (!deema)
                {
                    if (a > b)
                    {
                        s += a;
                        i++;
                    }
                    else
                    {
                        s += b;
                        j--;
                    }
                    deema = true;
                    sereja = false;
                    continue;
                }
                if (!sereja)
                {
                    if (a > b)
                    {
                        d += a;
                        i++;
                    }
                    else
                    {
                        d += b;
                        j--;
                    }
                    sereja = true;
                    deema = false;
                }
            }
            Console.WriteLine(s + " " + d);

        }
    }
}
