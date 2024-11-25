using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class _707A
    {
        public static void Result()
        {
            string[] input1 = Console.ReadLine().Split();
            int n = int.Parse(input1[0]);
            bool flag = false;
            while (n > 0)
            {
                string[] input2 = Console.ReadLine().Split();
                for (int i = 0; i < input2.Length; i++)
                {
                    if (input2[i] == "C" || input2[i] == "M" || input2[i] == "Y")
                    { Console.WriteLine("#Color"); return; }
                }
                n--;
            }
            Console.WriteLine("#Black&White");

        }
    }
}
