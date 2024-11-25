using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class _344A
    {
        public static void Result()
        {
            int n = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            int ans = 1;
            while (n > 1)
            {
                string inp = Console.ReadLine();
                if (inp != input)
                {
                    ans++;
                }
                input = inp;
                n--;
            }
            Console.WriteLine(ans);
            /*
            6
            10
            10
            10
            01
            10
            10
            */
        }
    }
}
