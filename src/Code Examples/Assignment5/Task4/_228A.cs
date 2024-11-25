using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class _228A
    {
        public static void Result()
        {
            string[] inputs = Console.ReadLine().Split(' ');

            int sum = 0;
            for (int i = 0; i < inputs.Length; i++)
            {
                int cnt = 0;
                for (int j = i + 1; j < inputs.Length; j++)
                {
                    if (inputs[i] == inputs[j])
                    {
                        cnt++;
                    }
                }
                if (cnt > 0)
                {
                    sum += cnt;
                }
                if (cnt > 1 && cnt <= 3)
                {
                    break;
                }

            }
            Console.WriteLine(sum);


        }
    }
}
