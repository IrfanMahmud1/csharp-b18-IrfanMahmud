using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class _705A
    {
        public static void Result()
        {
            int n = int.Parse(Console.ReadLine());

            string[] esp = new string[n];
            esp[0] = "I hate it";
            for (int i = 1; i < n; i++)
            {
                esp[i - 1] = i % 2 != 0 ? "I hate that" : "I love that";
                esp[i] = i % 2 != 0 ? "I love it" : "I hate it";
            }

            for (int i = 0; i < n; i++)
            {
                Console.Write(esp[i] + " ");
            }

        }
    }
}
