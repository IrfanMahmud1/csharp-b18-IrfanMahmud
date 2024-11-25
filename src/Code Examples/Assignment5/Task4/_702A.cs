using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class _702A
    {
        public static void Result()
        {
            int n = int.Parse(Console.ReadLine());
            int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            int c = 1, ans = 0;
            for (int i = 1; i < n; i++)
            {
                if (ar[i] > ar[i - 1])
                {
                    c++;
                }
                else
                {
                    ans = c > ans ? c : ans;
                    c = 1;
                }
            }
            ans = c > ans ? c : ans;
            Console.WriteLine(ans);
        }
    }
}
