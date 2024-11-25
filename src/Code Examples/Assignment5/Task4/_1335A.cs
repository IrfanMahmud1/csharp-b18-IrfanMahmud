using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class _1335A
    {
        public static void Result()
        {
            int t = int.Parse(Console.ReadLine());
            while (t > 0)
            {
                int n = int.Parse(Console.ReadLine());
                int ans = n > 2 ? n % 2 == 0 ? n / 2 - 1 : n / 2 : 0;
                Console.WriteLine(ans);
                t--;
            }
        }
    }
}
