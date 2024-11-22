using Assignment3;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http.Headers;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
namespace Task
{
    internal class Ludo
    {
        protected List<Player> Players { get; set; }
        protected Dice Dice { get; set; }
        protected GameBoard Board { get; set; }

        private readonly List<char> chars;

        protected int? NumberOfPlayers { get; set; }
        protected int Rank { get; set; }
        public Ludo()
        {
            Rank = 1;
            Board = new GameBoard();
            Players = new List<Player>()
            {
                new Player("Irfan","YELLOW","Y",Board.GetPositions(0),Board.GetPositions('Y')),
                new Player("Mahmud","GREEN", "G",Board.GetPositions(1),Board.GetPositions('G')),
                new Player("Ashik","BLUE", "B",Board.GetPositions(2),Board.GetPositions('B')),
                new Player("AI","RED", "R",Board.GetPositions(3),Board.GetPositions('R')),
            };

            Dice = new Dice();

            chars = new List<char>()
                {
                    'Y','G','B','R'
                };
        }

        private List<string> IsEligible(int dice, int player)
        {
            List<String> list = new List<String>();


            List<(int, int, int)> pos = Board.GetPositions(player);


            int SRow = 0, SCol = 0, ERow = 0, ECol = 0, i = 0;

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
                if (item.Value == pos[i])
                {
                    if (dice == 6)
                    {
                        list.Add(item.Key);
                    }
                }
                else
                {
                    if (item.Value.Item2 >= SCol && item.Value.Item2 <= ECol && item.Value.Item1 == SRow && player == 0)
                    {
                        if (item.Value.Item2 + 3 * dice <= ECol)
                        {
                            list.Add(item.Key);
                        }
                    }
                    else if (item.Value.Item1 >= SRow && item.Value.Item1 <= ERow && item.Value.Item2 == SCol && player == 1)
                    {
                        if (item.Value.Item1 + 2 * dice <= ERow)
                        {
                            list.Add(item.Key);
                        }
                    }
                    else if (item.Value.Item2 <= SCol && item.Value.Item2 >= ECol && item.Value.Item1 == SRow && player == 2)
                    {
                        if (item.Value.Item2 - 3 * dice >= ECol)
                        {
                            list.Add(item.Key);
                        }
                    }
                    else if (item.Value.Item1 <= SRow && item.Value.Item1 >= ERow && item.Value.Item2 == SCol && player == 3)
                    {
                        if (item.Value.Item1 - 2 * dice >= ERow)
                        {
                            list.Add(item.Key);
                        }
                    }

                    else
                    {
                        bool isSurvived = Players[player].SurvivedGuties.Any(x => x == item.Key);
                        if (!isSurvived)
                        {
                            list.Add(item.Key);
                        }
                    }
                }
                i++;
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
            if (cnt == NumberOfPlayers - 1)
            {
                Print("The game is over!");
            }
            return cnt >= NumberOfPlayers - 1;
        }
        private bool IsWon(int player)
        {
            int cnt = Players[player].SurvivedGuties.Count();
            if (cnt == 4)
            {
                Print(Players[player].Name + " is the winner and got a Rank : " + Rank);
            }
            return cnt == 4;
        }
        private bool IsFree(string guti, int player, (int, int, int) pos)
        {
            var b = Board.board;
            (int, int, int) initial = Players[player].Position[guti];
            (int, int, int) current = Players[player].CurrentPosition[guti];

            if (initial == current)
            {
                Players[player].StartPosition[pos].Add(guti);
                Players[player].CurrentPosition[guti] = pos;
                Players[player].Position[guti] = (initial.Item1, initial.Item2, initial.Item2);
                if (b[pos.Item1][pos.Item2] == ' ')
                {
                    b[pos.Item1][pos.Item2] = guti[0];
                    b[pos.Item1][pos.Item3] = guti[1];
                }
                return false;
            }
            return true;
        }

        private void MovePawn(int dice, string guti, int player)
        {
            var b = Board.board;
            for (int i = 0; i < 4; i++)
            {
                (int, int, int) posi = Board.GetPositions(chars[i]);
                var position = Players[i].StartPosition[posi];
                if (position.Any(x => x == guti))
                {
                    if (b[posi.Item1][posi.Item2] == guti[0] && b[posi.Item1][posi.Item3] == guti[1])
                    {
                        b[posi.Item1][posi.Item2] = ' ';
                        b[posi.Item1][posi.Item3] = ' ';
                    }
                    position.Remove(guti);
                    break;
                }
            }
            (int, int, int) pos = Board.MoveGuti(dice, guti, Players[player].CurrentPosition[guti]);

            if (pos == Board.GetPositions(guti))
            {
                Players[player].SurvivedGuties.Add(guti);
            }
            else
            {
                bool isStartPos = false;
                for (int i = 0; i < 4; i++)
                {
                    var position = Board.GetPositions(chars[i]);
                    if (position == pos)
                    {
                        isStartPos = true;
                        Players[i].StartPosition[pos].Add(guti);
                        break;
                    }
                }


                List<(int, int, int)> InitialPos = GetInitialPosition();
                List<(int, int, int)> SafePos = new List<(int, int, int)>()
                {
                    (3,19,20),(13,40,41),(27,25,26),(17,4,5)
                };
                bool flag = false;
                if (!InitialPos.Any(x => x == pos) && !SafePos.Any(x => x == pos) && !isStartPos)
                {
                    for (int i = 0; i < 4; i++)
                    {
                        foreach (var x in Players[i].CurrentPosition)
                        {
                            if (x.Value == pos)
                            {
                                flag = true;
                                (int, int, int) u = Players[i].Position[x.Key];
                                Players[i].Position[x.Key] = (u.Item1, u.Item2, u.Item2 + 1);
                                Players[i].CurrentPosition[x.Key] = (u.Item1, u.Item2, u.Item2 + 1);
                                break;
                            }
                        }
                        if (flag == true)
                        {
                            break;
                        }
                    }
                }
            }
            Players[player].CurrentPosition[guti] = pos;
        }

        private void SetInitialPositions()
        {
            var b = Board.board;
            for (int i = 0; i < 4; i++)
            {
                foreach (var j in Players[i].Position)
                {
                    if (j.Value != (j.Value.Item1, j.Value.Item2, j.Value.Item2))
                    {
                        b[j.Value.Item1][j.Value.Item2] = j.Key[0];
                        b[j.Value.Item1][j.Value.Item3] = j.Key[1];
                    }
                    else
                    {
                        b[j.Value.Item1][j.Value.Item2] = ' ';
                        b[j.Value.Item1][j.Value.Item2 + 1] = ' ';
                    }
                }
            }
        }
        private void SetStartPositions()
        {
            int start = 0, end = 0, col = 0;
            var b = Board.board;
            char c;

            for (int i = 0; i < 4; i++)
            {
                var pos = Board.GetPositions(chars[i]);
                if (i == 0)
                {
                    start = pos.Item1 - 2;
                    col = pos.Item2;
                    end = 1;
                    c = 'Y';
                }
                else if (i == 1)
                {
                    start = 11;
                    col = pos.Item2 + 4;
                    end = 1;
                    c = 'G';
                }
                else if (i == 2)
                {
                    start = 29;
                    col = pos.Item2;
                    end = pos.Item1 + 2;
                    c = 'B';
                }
                else
                {
                    start = 29;
                    col = pos.Item2 - 4;
                    end = 19;
                    c = 'R';
                }

                int s = start;
                while (s >= end)
                {
                    /*if (b[s][col] == ' ')
                    {
                        break;
                    }*/
                    b[s][col] = ' ';
                    b[s][col + 1] = ' ';
                    s--;
                }

                foreach (var it in Players[i].StartPosition[pos])
                {
                    if (b[pos.Item1][pos.Item2] == ' ')
                    {
                        b[pos.Item1][pos.Item2] = it[0];
                        b[pos.Item1][pos.Item3] = it[1];
                    }
                    else
                    {
                        if (start >= end && b[pos.Item1][pos.Item3] != it[1])
                        {
                            b[start][col] = it[0];
                            b[start][col + 1] = it[1];
                            start--;
                        }
                    }
                }
            }
        }
        private void SetSurvivedPositions()
        {
            var b = Board.board;
            int row = 0, col = 0;
            for (int i = 0; i < 4; i++)
            {
                if (i == 0) row = 14;
                else if (i == 1) row = 13;
                else if (i == 2) row = 17;
                else row = 16;
                col = 19;
                foreach (var pos in Players[i].SurvivedGuties)
                {
                    b[row][col] = pos[0];
                    b[row][col + 1] = pos[1];
                    col += 2;
                }
            }
        }

        private List<(int, int, int)> GetStartPosition()
        {
            List<(int, int, int)> StartPos = new List<(int, int, int)>();
            for (int i = 0; i < 4; i++)
            {
                StartPos.Add(Board.GetPositions(chars[i]));
            }
            return StartPos;
        }
        private List<(int, int, int)> GetInitialPosition()
        {

            List<(int, int, int)> InitialPos = new List<(int, int, int)>();
            for (int i = 0; i < 4; i++)
            {
                foreach (var j in Board.GetPositions(i))
                {
                    InitialPos.Add(j);
                }
            }
            return InitialPos;
        }
        private void SetCurrentPositions()
        {
            var b = Board.board;

            int start = 0, end = 0, line = 0;
            char c;
            for (int i = 0; i < 4; i++)
            {
                if (i == 0)
                {
                    start = 1;
                    line = 13;
                    end = 16;
                    c = 'Y';
                }
                else if (i == 1)
                {
                    start = 1;
                    line = 19;
                    end = 11;
                    c = 'G';
                }
                else if (i == 2)
                {
                    start = 28;
                    line = 13;
                    end = 43;
                    c = 'B';
                }
                else
                {
                    start = 19;
                    line = 19;
                    end = 29;
                    c = 'R';
                }
                var pos = Board.GetPositions(c);
                for (int j = start; j <= end;)
                {
                    if (i == 0 || i == 2)
                    {
                        if ((line, j, j + 1) != pos)
                        {
                            b[line][j] = ' ';
                            b[line][j + 1] = ' ';
                        }


                        b[line + 2][j] = ' ';
                        b[line + 2][j + 1] = ' ';

                        if ((line + 4, j, j + 1) != pos)
                        {
                            b[line + 4][j] = ' ';
                            b[line + 4][j + 1] = ' ';
                        }


                        j += 3;
                    }
                    else
                    {
                        if ((j, line, line + 1) != pos)
                        {
                            b[j][line] = ' ';
                            b[j][line + 1] = ' ';
                        }

                        b[j][line + 3] = ' ';
                        b[j][line + 4] = ' ';

                        if ((j, line + 6, line + 7) != pos)
                        {
                            b[j][line + 6] = ' ';
                            b[j][line + 7] = ' ';
                        }

                        j += 2;
                    }
                }
            }


            List<(int, int, int)> StartPos = GetStartPosition();
            List<(int, int, int)> InitialPos = GetInitialPosition();

            for (int i = 0; i < 4; i++)
            {

                foreach (var po in Players[i].CurrentPosition)
                {
                    if (StartPos.Any(x => x == po.Value) || InitialPos.Any(x => x == po.Value) || po.Value.Item1 >= 13 && po.Value.Item1 <= 17 && po.Value.Item2 >= 19 && po.Value.Item2 <= 25)
                    {
                        continue;
                    }
                    b[po.Value.Item1][po.Value.Item2] = po.Key[0];
                    b[po.Value.Item1][po.Value.Item3] = po.Key[1];
                }
            }
        }
        private void SetPositions()
        {
            SetInitialPositions();
            SetStartPositions();
            SetCurrentPositions();
            SetSurvivedPositions();
        }

        private string Read()
        {
            return Console.ReadLine();
        }
        private void Print()
        {
            Console.WriteLine();
        }
        private void Print(string text)
        {
            Console.WriteLine(text);
        }
        public void Play()
        {
            Print("Enter number of players : ");
            while (true)
            {
                NumberOfPlayers = int.Parse(Read());
                if (NumberOfPlayers >= 2 && NumberOfPlayers <=4)
                {
                    break;
                }
                Print("Invalid! Please select between 2 and 4");
            }
            while (!IsFinished())
            {
                for (int i = 0; i < NumberOfPlayers; i++)
                {
                    if (!IsWon(i))
                    {
                        int diceno = 0;
                        while (true)
                        {
                            if (i > 0)
                            {
                                Print();
                            }
                            SetPositions();
                            Board.Display();
                            Print();
                            string msg = "";
                            if (diceno == 6)
                            {
                                msg = "Player " + Players[i].Color + " " + Players[i].Name + " To roll your Dice Press Enter again : ";
                            }
                            else
                            {
                                msg = "Player " + Players[i].Color + " " + Players[i].Name + " To roll your Dice Press Enter : ";
                            }
                            Console.Write(msg);
                            string s = Console.ReadLine();
                            diceno = Dice.Roll();
                            Print("Your Dice is : " + diceno);
                            List<string> eligible = IsEligible(diceno, i);

                            string guti = "";

                            if (eligible.Count > 1)
                            {
                                if (i != 3)
                                {
                                    Console.Write("Enter your guti: ");
                                }
                                bool flag;
                                while (true)
                                {
                                    if (i != 3)
                                    {
                                        guti = Read().Trim().ToUpper();
                                    }
                                    else
                                    {
                                        guti = "R" + "" + Dice.Roll(1, 5);
                                    }
                                    flag = eligible.Any(x => x == guti);
                                    if (flag)
                                    {
                                        break;
                                    }
                                    if (i != 3)
                                    {
                                        Print("Not eligible! Please type again");
                                    }
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
                                    MovePawn(diceno, guti, i);
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