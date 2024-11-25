using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class _520A
    {
        public static void Result()
        {
            int n = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            int size = input.Length;
            if (size < 26)
            {
                Console.WriteLine("NO");
            }
            else
            {
                input = input.ToLower();
                int[] freq = new int[26];
                for (int i = 0; i < size; i++)
                {
                    freq[input[i] - 'a']++;
                }
                for (int i = 0; i < 26; i++)
                {
                    if (freq[i] == 0)
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
