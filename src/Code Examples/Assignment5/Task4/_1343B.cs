using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class _1343B
    {
        public static void Result()
        {
            int t = int.Parse(Console.ReadLine());
            while (t > 0)
            {
                int n = int.Parse(Console.ReadLine());
                if ((n / 2) % 2 != 0)
                {
                    Console.Write("No");
                }
                else
                {
                    Console.WriteLine("Yes");
                    int i = 2, j = 0, sum = 0;
                    while (j < n / 2)
                    {
                        Console.Write(i + " ");
                        sum += i;
                        i += 2;
                        j++;
                    }
                    i = 1;
                    j = 0;
                    n /= 2;
                    sum /= n;
                    while (j < n)
                    {
                        if (sum == i)
                        {
                            n++;
                        }
                        if (sum != i)
                        {
                            Console.Write(i + " ");
                        }
                        i += 2;
                        j++;
                    }
                }
                Console.WriteLine();
                t--;
            }

        }
    }
}
