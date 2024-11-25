using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class _1857A
    {
        public static void Result()
        {
            int t = int.Parse(Console.ReadLine());
            while (t > 0)
            {
                int n = int.Parse(Console.ReadLine());
                string[] input = Console.ReadLine().Split();
                int sum = 0;
                for (int i = 0; i < n; i++)
                {
                    int num = int.Parse(input[i]);
                    sum += num;
                }
                if (sum % 2 != 0)
                {
                    Console.WriteLine("No");
                }
                else
                {
                    Console.WriteLine("Yes");
                }
                t--;
            }

        }
    }
}
