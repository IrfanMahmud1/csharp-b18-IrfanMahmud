using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class _1703B
    {
        public static void Result()
        {
            int t = int.Parse(Console.ReadLine());
            while (t > 0)
            {
                Console.ReadLine();
                string input = Console.ReadLine();
                int[] freq = new int[27];
                int ans = 0;
                foreach (char s in input)
                {
                    freq[s - 'A']++;
                }
                foreach (char s in input)
                {
                    ans += freq[s - 'A'] != 0 ? freq[s - 'A'] + 1 : 0;
                    freq[s - 'A'] -= freq[s - 'A'];
                }
                Console.WriteLine(ans);
                t--;
            }

        }
    }
}
