using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class _467A
    {
        public static void Display()
        {
            int n = int.Parse(Console.ReadLine());
            int ans = 0;
            while (n > 0)
            {
                string[] rooms = Console.ReadLine().Split(' ');
                int students = int.Parse(rooms[0]), capacity = int.Parse(rooms[1]);
                if (capacity - students >= 2)
                {
                    ans++;
                }
                n--;
            }
            Console.WriteLine(ans);

        }
    }
}
