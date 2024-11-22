using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class Dice
    {
        public Random _Random {get;set;}

        public Dice()
        {
            _Random = new Random();
        }
        public int Roll(int a = 1, int b = 7)
        {
            return _Random.Next(a, b);
        }
    }
}
