using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class _785A
    {
        public static void Result()
        {
            int n = int.Parse(Console.ReadLine());
            int ans = 0;
            for (int i = 0; i < n; i++)
            {
                string s = Console.ReadLine();
                if (s == "Tetrahedron")
                {
                    ans += 4;
                }
                else if (s == "Cube")
                {
                    ans += 6;
                }
                else if (s == "Octahedron")
                {
                    ans += 8;
                }
                else if (s == "Dodecahedron")
                {
                    ans += 12;
                }
                else
                {
                    ans += 20;
                }
            }
            Console.WriteLine(ans);
        }
    }
}
