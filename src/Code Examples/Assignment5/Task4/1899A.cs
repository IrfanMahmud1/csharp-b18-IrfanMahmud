using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class _1899A
    {
        public static void Result()
        {
            int t = int.Parse(Console.ReadLine());
            while (t > 0)
            {
                int n = int.Parse(Console.ReadLine());
                if ((n + 1) % 3 == 0 || (n - 1) % 3 == 0)
                {
                    Console.WriteLine("First");
                }
                else
                {
                    Console.WriteLine("Second");
                }
                t--;
            }

        }
    }
}
