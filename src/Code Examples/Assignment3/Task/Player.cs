using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class Player
    {
        public string Name { get; set; }
        public Dictionary<string, (int,int,int)> Position { get; set; }

        public Dictionary<string,(int,int,int)>CurrentPosition { get; set; }
        public Dictionary<(int,int,int),List<string>> StartPosition { get; set; }

        public List<string> SurvivedGuties { get; set; }
        public Player(string name, string key, List<(int,int,int)> pos, (int,int,int) pos2)
        {
            Name = name;
            Position = new Dictionary<string, (int, int, int)>();
            for (int i = 1; i <= pos.Count; i++)
            {
                Position[key + i] = pos[i - 1];
            }
            CurrentPosition = new Dictionary<string, (int, int, int)>();
            for (int i = 1; i <= pos.Count; i++)
            {
                CurrentPosition[key + i] = pos[i - 1];
            }
            StartPosition = new Dictionary<(int, int, int), List<string>>();
            StartPosition[pos2] = new List<string>();

            SurvivedGuties = new List<string>();
        }
    }
}
