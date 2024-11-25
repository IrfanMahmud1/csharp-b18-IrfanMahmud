
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class _271A
    {
        public static void Result()
        {
            int y = int.Parse(Console.ReadLine().Trim());

            y++;

            while (true)
            {
                string s = y.ToString();
                bool ans = false;
                int[] freq = new int[10];

                for (int i = 0; i < s.Length; i++)
                {
                    freq[s[i] - '0']++;
                }
                foreach (int i in freq)
                {
                    if (i > 1)
                    {
                        ans = true;
                        break;
                    }
                }
                if (ans)
                {
                    y++;
                }
                else
                {
                    Console.WriteLine(s);
                    break;
                }
            }

        }
    }
}
