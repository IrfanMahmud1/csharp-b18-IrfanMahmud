using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    public class _110A
    {
        public static void Result()
        {
            string input = Console.ReadLine();

            int sum = 0;

            foreach (char c in input)
            {
                sum += c == '4' || c == '7' ? 1 : 0;
            }

            string ans = sum == 4 || sum == 7 ? "YES" : "NO";
            Console.WriteLine(ans);


        }
    }
}
