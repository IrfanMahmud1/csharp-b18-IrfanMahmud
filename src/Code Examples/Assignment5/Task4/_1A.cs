using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    public class _1A
    {
        public void Result()
        {
            var input = Console.ReadLine().Split(' ');

            var m = BigInteger.Parse(input[0]);
            var n = BigInteger.Parse(input[1]);
            var a = BigInteger.Parse(input[2]);
            BigInteger ans = 0;
            var x = m * n;
            var y = a * a;
            if (x <= y)
            {
                ans = 1;
            }
            else
            {
                if (m > a)
                {
                    if (m % a != 0)
                        ans += (m / a + 1);
                    else
                        ans += m / a;
                }
                if (n > a)
                {
                    if (ans == 0)
                    {
                        ans = 1;
                    }
                    if (n % a != 0)
                        ans *= n / a + 1;
                    else
                        ans *= n / a;
                }
            }
            Console.WriteLine(ans);

        }
    }
}
