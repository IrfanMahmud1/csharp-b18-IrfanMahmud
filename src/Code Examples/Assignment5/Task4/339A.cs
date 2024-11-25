using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal static class _339
    {
        public static void Result()
        {

            string[] input = Console.ReadLine().Trim().Split('+');
            Array.Sort(input);
            string ans = "";
            ans += input[0];
            for (int i = 1; i < input.Length; i++)
            {
                ans += "+" + input[i];
            }

            Console.WriteLine(ans);

        }
    }
}
