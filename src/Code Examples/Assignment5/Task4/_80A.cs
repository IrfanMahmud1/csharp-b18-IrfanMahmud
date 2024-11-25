using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    public class _80A
    {
        public void Result()
        {
            var input = Console.ReadLine().Split(' ');
            int a = int.Parse(input[0]);
            int b = int.Parse(input[1]);

            bool[] prime = new bool[b + 1];

            for (int i = 2; i * i <= b; i++)
            {
                for (int j = i; i * j <= b; j++)
                {
                    prime[i * j] = true;
                }

            }
            for (int i = a + 1; i <= b; i++)
            {
                if (!prime[i] && i != b || prime[i] && i == b)
                {
                    Console.WriteLine("NO");
                    return;
                }
            }
            Console.WriteLine("YES");
        }
    }
}
