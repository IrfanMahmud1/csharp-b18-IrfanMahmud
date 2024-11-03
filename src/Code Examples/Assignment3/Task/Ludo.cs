using Assignment3;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
namespace Task
{
    internal class Ludo
    {
        protected List<Player> Players { get; set; }
        protected Dice Dice { get; set; }
        protected GameBoard Board { get; set; }


        public Ludo()
        {
            Board = new GameBoard();
            Players = new List<Player>()
            {
                new Player("Irfan","Y",Board.GetPositions(0),Board.GetPositions('Y')),
                new Player("Mahmud","G",Board.GetPositions(1),Board.GetPositions('G')),
                new Player("Ashik","B",Board.GetPositions(2),Board.GetPositions('B')),
                new Player("AI","R",Board.GetPositions(3),Board.GetPositions('R')),
            };
        }

        public List<string> IsEligible(int dice, int player)
        {
            var b = Board.board;
            List<String> list = new List<String>();
            int cnt = 0, row = 0, col = 0;
            char c = ' ';


            List<(int, int, int)> pos = Board.GetPositions(player);

            row = pos[0].Item1;
            col = pos[0].Item2;
            if (dice == 6)
            {
                for (int m = row; m <= row + 1; m++)
                {
                    for (int n = col; n <= col + 3; n += 3)
                    {
                        if (b[m][n] != ' ')
                        {
                            list.Add(b[m][n] + "" + b[m][n + 1]);
                        }
                    }
                }
            }
            if (list.Count < 4 && dice <= 6)
            {
                int SRow = 0, SCol = 0, ERow = 0, ECol = 0;

                if (player == 0)
                {
                    SRow = 15;
                    ERow = 15;
                    SCol = 1;
                    ECol = 19;
                }
                else if (player == 1)
                {
                    SRow = 1;
                    ERow = 13;
                    SCol = 22;
                    ECol = 22;
                }
                else if (player == 2)
                {
                    SRow = 15;
                    ERow = 15;
                    SCol = 43;
                    ECol = 25;
                }
                else
                {
                    SRow = 29;
                    ERow = 17;
                    SCol = 22;
                    ECol = 22;
                }

                foreach (var item in Players[player].CurrentPosition)
                {
                    if (SRow == ERow && SRow == item.Value.Item1)
                    {
                        if (SCol < ECol && item.Value.Item2 + 3 * dice <= ECol)
                        {
                            list.Add(item.Key);
                        }
                        else if (SCol > ECol && item.Value.Item2 - 3 * dice >= ECol)
                        {
                            list.Add(item.Key);
                        }
                    }
                    else if (SCol == ECol && SCol == item.Value.Item2)
                    {
                        if (SRow > ERow && item.Value.Item1 + 3 * dice <= ERow)
                        {
                            list.Add(item.Key);
                        }
                        else if (SRow < ERow && item.Value.Item1 - 3 * dice >= ERow)
                        {
                            list.Add(item.Key);
                        }
                    }

                    else
                    {
                        int rw = Players[player].Position[item.Key].Item1;
                        int cl = Players[player].Position[item.Key].Item2;

                        if (rw != item.Value.Item1 || cl != item.Value.Item2 && item.Value != (-1, -1, -1))
                        {
                            list.Add(item.Key);
                        }
                    }
                }
            }

            return list;

        }

        private bool IsFinished()
        {
            int cnt = 0;
            for (int i = 0; i < Players.Count; i++)
            {
                if (Players[i].SurvivedGuties.Count() == 4)
                {
                    cnt++;
                }
            }

            return cnt >= 3;
        }
        private bool IsWon(int player)
        {
            int cnt = Players[player].SurvivedGuties.Count();
            return cnt == 4;
        }

        public void OrganizeStartPositionGuties(string guti, int player, (int, int, int) pos)
        {
            int start = 0, end = 0,col = 0;
            var b = Board.board;
            if (player == 0)
            {
                start = pos.Item1 - 2;
                col = pos.Item2;
                end = 1;
            }
            else if (player == 1)
            {
                start = 11;
                col = pos.Item2 + 4;
                end = 1;
            }
            else if (player == 2)
            {
                start = 29;
                col = pos.Item2;
                end = pos.Item1 + 2;
            }
            else
            {
                start = 29;
                col = pos.Item2 - 4;
                end = 19;
            }

            bool check = Players[player].StartPosition[pos].Any(x => x == guti);

            for (int i = start; i >= end; i--)
            {
                if (check)
                {
                    if (b[pos.Item1][pos.Item2] == guti[0] && b[pos.Item1][pos.Item3] == guti[1])
                    {
                        b[pos.Item1][pos.Item2] = ' ';
                        b[pos.Item1][pos.Item2] = ' ';
                        break;
                    }
                    else
                    {
                        if (b[i][col] == guti[0] && b[i][col + 1] == guti[1])
                        {
                            b[i][col] = ' ';
                            b[i][col + 1] = ' ';
                            break;
                        }
                    }
                }
                else
                {
                    if (b[pos.Item1][pos.Item2] != ' ')
                    {
                        if (b[i][col] == ' ')
                        {
                            b[i][col] = b[pos.Item1][pos.Item2];
                            b[i][col + 1] = b[pos.Item1][pos.Item3];
                        }
                    }
                    b[pos.Item1][pos.Item2] = guti[0];
                    b[pos.Item1][pos.Item3] = guti[1];
                    break;
                }
            }
        }
        public bool IsFree(string guti, int player, (int, int, int) pos)
        {
            var b = Board.board;
            (int, int, int) initial = Players[player].Position[guti];
            (int, int, int) current = Players[player].CurrentPosition[guti];

            if (initial == current)
            {
                OrganizeStartPositionGuties(guti, player, pos);
                Players[player].StartPosition[pos].Add(guti);
                Players[player].CurrentPosition[guti] = pos;

                b[initial.Item1][initial.Item2] = ' ';
                b[initial.Item1][initial.Item3] = ' ';
                return false;
            }
            return true;
        }
        public void Play()
        {
            while (!IsFinished())
            {
                for (int i = 0; i < Players.Count; i++)
                {
                    if (!IsWon(i))
                    {
                        int diceno = 0;
                        while (true)
                        {
                            if (i > 0)
                            {
                                Console.WriteLine();
                            }
                            Board.Display();
                            Console.WriteLine();
                            string msg = "";
                            if (diceno == 6)
                            {
                                msg = "Player " + (i + 1).ToString() + " " + Players[i].Name + " To roll your Dice Press Enter again : ";
                            }
                            else
                            {
                                msg = "Player " + (i + 1).ToString() + " " + Players[i].Name + " To roll your Dice Press Enter : ";
                            }
                            Console.Write(msg);
                            Console.ReadLine();
                            diceno = Dice.Roll();
                            Console.WriteLine("Your Dice is : " + diceno);
                            List<string> eligible = IsEligible(diceno, i);

                            string guti = "";

                            if (eligible.Count > 1)
                            {
                                Console.Write("Enter your guti: ");
                                bool flag;
                                while (true)
                                {
                                    guti = Console.ReadLine().Trim().ToUpper();
                                    flag = eligible.Any(x => x == guti);
                                    if (flag)
                                    {
                                        break;
                                    }
                                    Console.WriteLine("Not eligible! Please type again");
                                }
                            }
                            else if (eligible.Count == 1)
                            {
                                guti = eligible[0];
                            }
                            bool isfree = true;
                            if (eligible.Count != 0)
                            {
                                if (diceno == 6)
                                {
                                    isfree = IsFree(guti, i, Board.GetPositions(guti[0]));
                                }
                                if (isfree)
                                {
                                    (int, int, int) pos = Board.MoveGuti(diceno, guti, Players[i].CurrentPosition[guti]);
                                    /* while (true)
                                     {
                                         if (pos == (-2, -2, -2))
                                         {
                                             pos = Board.MoveGuti(diceno, guti, Players[i].CurrentPosition[guti]);
                                         }
                                         else
                                         {
                                             break;
                                         }

                                     }*/
                                    Players[i].CurrentPosition[guti] = pos;
                                    if (pos == (-1, -1, -1))
                                    {
                                        Players[i].SurvivedGuties.Add(guti);
                                    }
                                    else
                                    {
                                        for (int j = 0; j < 4; j++)
                                        {
                                            foreach (var x in Players[j].StartPosition)
                                            {
                                                if (x.Value.Any(x => x == guti))
                                                {
                                                    //OrganizeStartPositionGuties(guti, j, x.Key);
                                                    x.Value.Remove(guti);
                                                    break;
                                                }
                                                if (x.Key == pos)
                                                {
                                                    //OrganizeStartPositionGuties(guti, j, x.Key);
                                                    x.Value.Add(guti);
                                                    break;
                                                }
                                            }
                                        }
                                    }
                                }
                            }

                            if (diceno != 6)
                            {
                                break;
                            }
                        }

                    }
                }
            }
        }
    }
}