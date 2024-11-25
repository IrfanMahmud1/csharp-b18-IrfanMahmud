using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    public class _1030A
    {
        public static void Result()
        {
            int n = int.Parse(Console.ReadLine());
            string[] input = Console.ReadLine().Split();

            foreach (string s in input)
            {
                if (s == "1")
                {
                    Console.WriteLine("HARD");
                    return;
                }
            }
            Console.WriteLine("EASY");

        }
    }
}
