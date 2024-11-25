using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class _236A
    {
        public static void Result()
        {
            string input = Console.ReadLine();

            int[] letters = new int[26];

            for (int i = 0; i < input.Length; i++)
            {
                letters[input[i] - 'a']++;
            }

            int distinct = letters.Count(x => x > 0);
            string ans = distinct % 2 != 0 ? "IGNORE HIM!" : "CHAT WITH HER!";
            Console.WriteLine(ans);
        }
    }
}
