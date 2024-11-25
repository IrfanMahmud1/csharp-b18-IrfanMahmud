using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class _148A
    {
        public static void Result()
        {
            int t = 0;
            int[] input = new int[5];
            while (t < 5)
            {
                input[t++] = int.Parse(Console.ReadLine());
            }
            if (input[0] == 1)
            {
                Console.WriteLine(input[4]);
                return;
            }
            int sz = input[4] + 1;
            bool[] cnt = new bool[sz];
            for (int i = 0; i < 4; i++)
            {
                if (input[i] < sz && cnt[input[i]] == true)
                {
                    continue;
                }
                for (int j = input[i]; j < sz; j += input[i])
                {
                    if (cnt[j] == false)
                    {
                        cnt[j] = true;
                    }
                }
            }
            int ans = 0;
            for (int i = 1; i < sz; i++)
            {
                if (cnt[i] == true)
                {
                    ans++;
                }
            }
            Console.WriteLine(ans);

        }
    }
}
