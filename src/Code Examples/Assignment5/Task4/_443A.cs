using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class _443A
    {
        public static void Result()
        {
            string input = Console.ReadLine();
            int n = input.Length;
            int[] freq = new int[27];
            for (int i = 0; i < n; i++)
            {
                if (input[i] >= 'a' && input[i] <= 'z')
                {
                    freq[input[i] - 'a']++;
                }
            }
            int ans = 0;
            for (int i = 0; i < 27; i++)
            {
                ans += freq[i] != 0 ? 1 : 0;
            }
            Console.WriteLine(ans);

        }
    }
}
