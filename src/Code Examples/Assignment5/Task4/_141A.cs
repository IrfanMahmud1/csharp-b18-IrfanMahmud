using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class _141A
    {
        public static void Result()
        {
            string g = Console.ReadLine();
            string h = Console.ReadLine();
            string shuffle = Console.ReadLine();

            if (g.Length + h.Length != shuffle.Length)
            {
                Console.WriteLine("NO");
            }
            else
            {
                int[] freq = new int[27];
                foreach (char c in g)
                {
                    freq[c - 'A']++;
                }
                foreach (char c in h)
                {
                    freq[c - 'A']++;
                }
                foreach (char c in shuffle)
                {
                    freq[c - 'A']--;
                }
                foreach (int c in freq)
                {
                    if (c != 0)
                    {
                        Console.WriteLine("NO");
                        return;
                    }
                }
                Console.WriteLine("YES");
            }

        }
    }
}
