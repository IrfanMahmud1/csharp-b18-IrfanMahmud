using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class _200B
    {
        public static void Result()
        {
            int n = int.Parse(Console.ReadLine());
            string[] drinks = Console.ReadLine().Split(' ');

            int sum = 0;

            foreach (string drink in drinks)
            {
                int val = int.Parse(drink);
                sum += val;
            }
            Console.WriteLine((decimal)sum / n);

        }
    }
}
