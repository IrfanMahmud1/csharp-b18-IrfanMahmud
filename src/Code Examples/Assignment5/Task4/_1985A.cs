using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    public class _1985A
    {
        public void Result()
        {

            var t = int.Parse(Console.ReadLine());

            while (t > 0)
            {
                var input = Console.ReadLine().Split(' ');
                var a = input[0].ToArray();
                var b = input[1].ToArray();
                var temp = a[0];
                a[0] = b[0];
                b[0] = temp;
                Console.WriteLine(string.Join("", a) + " " + string.Join("", b));
                t--;
            }

        }
    }
}
