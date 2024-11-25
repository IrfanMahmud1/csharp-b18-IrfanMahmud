using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class _472A
    {
        public static void Result()
        {
            int n = int.Parse(Console.ReadLine());

            static bool IsPrime(int x)
            {
                for (int i = 2; i < x; i++)
                {
                    if (x % i == 0)
                    {
                        return false;
                    }
                }
                return true;
            }

            int i = n / 2, j = n - n / 2;
            bool a = true;
            bool b = true;
            while (a || b)
            {
                a = IsPrime(i);
                b = IsPrime(j);
                if (a || b)
                {
                    i--;
                    j++;
                }
            }
            Console.WriteLine(i + " " + j);
        }
    }
}
