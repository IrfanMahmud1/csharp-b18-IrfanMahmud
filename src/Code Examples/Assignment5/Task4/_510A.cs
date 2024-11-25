using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class _510A
    {
        public static void Result()
        {
            string[] inputs = Console.ReadLine().Split();

            int n = int.Parse(inputs[0]), m = int.Parse(inputs[1]);
            bool start = false, end = true;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (i % 2 == 0)
                    {
                        Console.Write('#');
                    }
                    else
                    {
                        if (end && j == m - 1)
                        {
                            Console.Write('#');
                            end = false;
                            start = true;
                            break;
                        }
                        else if (start && j == 0)
                        {
                            Console.Write('#');
                            continue;
                        }
                        if (start && j == m - 1)
                        {
                            end = true;
                            start = false;
                        }
                        Console.Write('.');
                    }
                }
                Console.WriteLine();
            }

        }
    }
}
