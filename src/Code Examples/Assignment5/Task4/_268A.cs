using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class _268A
    {
        public static void Result()
        {
            int n = int.Parse(Console.ReadLine());
            int[,] input = new int[n, 2];
            for (int i = 0; i < n; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                for (int j = 0; j < 2; j++)
                {
                    input[i, j] = int.Parse(s[j]);
                }
            }
            int ans = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (input[i, 0] == input[j, 1] && i != j)
                    {
                        ans++;
                    }
                }

            }
            Console.WriteLine(ans);
        }
    }
}
