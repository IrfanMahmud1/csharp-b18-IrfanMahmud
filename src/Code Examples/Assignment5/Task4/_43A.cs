using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    public class _43A
    {
        public void Result()
        {
            var n = int.Parse(Console.ReadLine());

            Dictionary<string, int> result = new Dictionary<string, int>();
            var ans = 0;
            for (int i = 0; i < n; i++)
            {
                var s = Console.ReadLine();
                if (!result.ContainsKey(s))
                    result.Add(s, 0);
                result[s]++;
                ans = Math.Max(ans, result[s]);

            }

            foreach (var s in result)
            {
                if (s.Value == ans)
                {
                    Console.WriteLine(s.Key);
                    break;
                }
            }

        }
    }
}
