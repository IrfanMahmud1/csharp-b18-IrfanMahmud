using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class _1742A
    {
        public static void Result()
        {
            int n = int.Parse(Console.ReadLine());
            while (n > 0)
            {
                string ans = "";
                string[] input = Console.ReadLine().Split(' ');

                int a = int.Parse(input[0]), b = int.Parse(input[1]), c = int.Parse(input[2]);

                ans = a + b == c || a + c == b || b + c == a ? "YES" : "NO";
                Console.WriteLine(ans);
                n--;
            }


        }
    }
}
