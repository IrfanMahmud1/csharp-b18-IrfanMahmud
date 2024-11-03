using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class Dice
    {
        public static int Roll()
        {
            Random random = new Random();
            return random.Next(1, 7);
        }
    }
}
