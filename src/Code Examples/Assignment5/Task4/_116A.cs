using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class _116A
    {
      public  static void Result()
        {
            int n = int.Parse(Console.ReadLine());
            int ans = 0, trump = 0;
            while (n > 0)
            {
                string[] inputs = Console.ReadLine().Split();
                int exit = int.Parse(inputs[0]);
                int enter = int.Parse(inputs[1]);
                trump -= exit;
                trump += enter;
                ans = trump > ans ? trump : ans;
                n--;
            }
            Console.WriteLine(ans);
        }
    }
}
