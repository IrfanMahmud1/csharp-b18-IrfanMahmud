using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class _1926A
    {
        public static void Result()
        {
            int t = int.Parse(Console.ReadLine());

            while (t > 0)
            {
                string s = Console.ReadLine();
                int a = 0, b = 0;
                foreach (char c in s)
                {
                    if (c == 'A')
                    {
                        a++;
                    }
                    else
                    {
                        b++;
                    }
                }
                Console.WriteLine(a > b ? "A" : "B");
                t--;
            }

        }
    }
}
