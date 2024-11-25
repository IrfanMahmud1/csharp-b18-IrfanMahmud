using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class _1997A
    {
        public static void Result()
        {
            int n = int.Parse(Console.ReadLine());
            while (n > 0)
            {
                string ans = "";
                string s = Console.ReadLine();
                bool flag = false;
                ans += s[0];
                for (int i = 1; i < s.Length; i++)
                {
                    if (s[i] == s[i - 1] && !flag)
                    {
                        ans += s[i] < 'z' ? (char)(s[i] + 1) : (char)(s[i] - 1);
                        flag = true;
                    }
                    ans += s[i];
                }
                if (flag == false)
                {
                    char c = s[s.Length - 1];
                    ans += c < 'z' ? (char)(c + 1) : (char)(c - 1);
                }
                Console.WriteLine(ans);
                n--;
            }

        }
    }
}
