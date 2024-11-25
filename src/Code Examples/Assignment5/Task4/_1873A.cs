using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    public class _1873A
    {
        public static void Result()
        {
            int t = int.Parse(Console.ReadLine());

            while (t > 0)
            {
                char[] s = Console.ReadLine().ToArray();

                bool ans = false;
                for (int i = 0; i < s.Length; i++)
                {
                    char c = (char)(97 + i);
                    if (c == s[i])
                    {
                        ans = true;
                        break;
                    }
                }
                if (ans)
                {
                    Console.WriteLine("Yes");
                }
                else
                {
                    Console.WriteLine("No");
                }
                t--;
            }
        }
    }
}
