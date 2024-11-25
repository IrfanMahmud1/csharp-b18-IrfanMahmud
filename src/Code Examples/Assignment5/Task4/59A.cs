using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal static class Word
    {
        public static void Result()
        {
            string inputLine = Console.ReadLine().Trim();

            int low = 0, upp = 0;

            for (int i = 0; i < inputLine.Length; i++)
            {
                low += inputLine[i] >= 'a' && inputLine[i] <= 'z' ? 1 : 0;
                upp += inputLine[i] >= 'A' && inputLine[i] <= 'Z' ? 1 : 0;
            }

            string ans = low >= upp ? inputLine.ToLower() : inputLine.ToUpper();
            Console.Write(ans);
        }
    }
}
