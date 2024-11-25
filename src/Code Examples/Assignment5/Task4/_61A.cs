using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class _61A
    {
        public static void Result()
        {
            string in1 = Console.ReadLine().Trim();
            string in2 = Console.ReadLine().Trim();
            string ans = "";

            for (int i = 0; i < in1.Length; i++)
            {
                if (in1[i] == in2[i])
                {
                    ans += '0';
                }
                else
                {
                    ans += '1';
                }
            }
            Console.WriteLine(ans);

        }
    }
}
