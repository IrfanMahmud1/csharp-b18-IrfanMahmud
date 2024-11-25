using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class _490A
    {
        public static void Result()
        {
            int n = int.Parse(Console.ReadLine());
            string[] input = Console.ReadLine().Split();
            int len = input.Length;
            int p = 0, m = 0, pe = 0;
            for (int i = 0; i < len; i++)
            {
                int val = int.Parse(input[i]);
                if (val == 1)
                {
                    p++;
                }
                else if (val == 2)
                {
                    m++;
                }
                else
                {
                    pe++;
                }
            }
            int mn = p;
            mn = Math.Min(mn, m);
            mn = Math.Min(mn, pe);
            Console.WriteLine(mn);
            bool[] pro = new bool[len];
            while (mn > 0)
            {
                bool P = false, M = false, E = false;
                int sum = 0;
                for (int i = 0; i < len; i++)
                {
                    int val = int.Parse(input[i]);
                    if (val == 1 && pro[i] == false && !P)
                    {
                        Console.Write(i + 1 + " ");
                        pro[i] = true;
                        P = true;
                        sum++;
                    }
                    else if (val == 2 && pro[i] == false && !M)
                    {
                        Console.Write(i + 1 + " ");
                        pro[i] = true;
                        M = true;
                        sum++;
                    }
                    else if (val == 3 && pro[i] == false && !E)
                    {
                        Console.Write(i + 1 + " ");
                        pro[i] = true;
                        E = true;
                        sum++;
                    }
                    if (sum == 3)
                    {
                        break;
                    }
                }
                Console.WriteLine();
                mn--;
            }

        }
    }
}
