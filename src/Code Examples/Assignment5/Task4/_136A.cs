using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class _136A
    {
        public static void Result()
        {
            int n = int.Parse(Console.ReadLine());
            string[] gifts = Console.ReadLine().Split(' ');
            int[] ans = new int[n];

            for (int i = 0; i < n; i++)
            {
                ans[int.Parse(gifts[i]) - 1] = i + 1;
            }

            foreach (int i in ans)
            {
                Console.Write(i + " ");
            }
        }
    }
}
