using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class _749A
    {
        public static void Result()
        {
            int n = int.Parse(Console.ReadLine());
            int k = n / 2;
            if (n % 2 != 0)
            {
                k--;
            }
            Console.WriteLine(n / 2);
            while (k > 0)
            {
                Console.Write(2 + " ");
                k--;
            }
            if (n % 2 != 0)
                Console.Write(3);
        }
    }
}
