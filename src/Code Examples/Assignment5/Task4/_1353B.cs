using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class _1353B
    {
        public static void Result()
        {
            int t = int.Parse(Console.ReadLine());

            while (t > 0)
            {
                string[] input = Console.ReadLine().Split();
                int n = int.Parse(input[0]), k = int.Parse(input[1]);
                int[] a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                int[] b = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                Array.Sort(a);
                Array.Sort(b);
                for (int i = 0, j = b.Length - 1; k > 0;)
                {
                    if (a[i] < b[j])
                    {
                        int v = b[j];
                        b[j] = a[i];
                        a[i] = v;
                        i++;
                        j--;
                    }
                    k--;
                }
                int sum = 0;
                foreach (int s in a)
                {
                    sum += s;
                }
                Console.WriteLine(sum);
                t--;
            }

        }
    }
}
