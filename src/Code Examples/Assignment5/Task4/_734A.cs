using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class _734A
    {
        public static void Result()
        {
            int n = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();

            int Anton = 0, Danik = 0;
            for (int i = 0; i < n; i++)
            {
                if (input[i] == 'A')
                {
                    Anton++;
                }
                else
                {
                    Danik++;
                }
            }
            if (Anton > Danik)
            {
                Console.WriteLine("Anton");
            }
            else if (Anton < Danik)
            {
                Console.WriteLine("Danik");
            }
            else
            {
                Console.WriteLine("Friendship");

            }


        }
    }
}
