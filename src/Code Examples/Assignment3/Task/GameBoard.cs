﻿using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class GameBoard
    {
        public StringBuilder[] board { get; set; }

        public GameBoard()
        {
            board = new StringBuilder[31];
            board[0] = new StringBuilder("##############################################");
            board[1] = new StringBuilder("#                 #  |  |  #                 #");
            board[2] = new StringBuilder("#                 #--|--|--#                 #");
            board[3] = new StringBuilder("#     YELLOW      #  |  |  #      GREEN      #");
            board[4] = new StringBuilder("#                 #--|--|--#                 #");
            board[5] = new StringBuilder("#     -------     #  |  |  #     -------     #");
            board[6] = new StringBuilder("#     |  |  |     #--|--|--#     |  |  |     #");
            board[7] = new StringBuilder("#     |  |  |     #  |  |  #     |  |  |     #");
            board[8] = new StringBuilder("#     -------     #--|--|--#     -------     #");
            board[9] = new StringBuilder("#                 #  |  |  #                 #");
            board[10] = new StringBuilder("#                 #--|--|--#                 #");
            board[11] = new StringBuilder("#                 #  |  |  #                 #");
            board[12] = new StringBuilder("###################--------###################");
            board[13] = new StringBuilder("#  |  |  |  |  |  |        |  |  |  |  |  |  #");
            board[14] = new StringBuilder("#--################        ################--#");
            board[15] = new StringBuilder("#  |  |  |  |  |  |        |  |  |  |  |  |  #");
            board[16] = new StringBuilder("#--################        ################--#");
            board[17] = new StringBuilder("#  |  |  |  |  |  |        |  |  |  |  |  |  #");
            board[18] = new StringBuilder("###################--------###################");
            board[19] = new StringBuilder("#                 #  |  |  #                 #");
            board[20] = new StringBuilder("#                 #--|--|--#                 #");
            board[21] = new StringBuilder("#       RED       #  |  |  #      BLUE       #");
            board[22] = new StringBuilder("#                 #--|--|--#                 #");
            board[23] = new StringBuilder("#     -------     #  |  |  #     -------     #");
            board[24] = new StringBuilder("#     |  |  |     #--|--|--#     |  |  |     #");
            board[25] = new StringBuilder("#     |  |  |     #  |  |  #     |  |  |     #");
            board[26] = new StringBuilder("#     -------     #--|--|--#     -------     #");
            board[27] = new StringBuilder("#                 #  |  |  #                 #");
            board[28] = new StringBuilder("#                 #--|--|--#                 #");
            board[29] = new StringBuilder("#                 #  |  |  #                 #");
            board[30] = new StringBuilder("##############################################");

            /*
           "##############################################",
           "#                 #  |  |  #                 #",
           "#                 #--|--|--#                 #",
           "#                 #  |  |  #                 #",
           "#                 #--|--|--#                 #",
           "#     -------     #  |  |  #     -------     #",
           "#     |  |  |     #--|--|--#     |  |  |     #",
           "#     |  |  |     #  |  |  #     |  |  |     #",
           "#     -------     #--|--|--#     -------     #",
           "#                 #  |  |  #                 #",
           "#                 #--|--|--#                 #",
           "#                 #  |  |  #                 #",
           "###################__|__|__###################",
           "#  |  |  |  |  |  |        |  |  |  |  |  |  #",
           "#--################        ################--#",
           "#  |  |  |  |  |  |        #  |  |  |  |  |  #",
           "#--################        ################--#",
           "#  |  |  |  |  |  |        |  |  |  |  |  |  #",
           "#--################--------################--#",
           "#                 #  |  |  #                 #",
           "#                 #--|--|--#                 #",
           "#                 #  |  |  #                 #",
           "#                 #--|--|--#                 #",
           "#     -------     #  |  |  #     -------     #",
           "#     |  |  |     #--|--|--#     |  |  |     #",
           "#     |  |  |     #  |  |  #     |  |  |     #",
           "#     -------     #--|--|--#     -------     #",
           "#                 #  |  |  #                 #",
           "#                 #--|--|--#                 #",
           "#                 #  |  |  #                 #",
           "##############################################"
       };
           */
        }

        //Getting start positions of players
        public (int, int, int) GetPositions(char key)
        {
            (int, int, int) pos;
            if (key == 'Y')
            {
                pos = (13, 4, 5);
            }
            else if (key == 'G')
            {
                pos = (3, 25, 26);
            }
            else if (key == 'B')
            {
                pos = (17, 40, 41);
            }
            else
            {
                pos = (27, 19, 20);
            }
            return pos;
        }

        //Getting Initial positions of players
        public List<(int, int, int)> GetPositions(int player)
        {
            List<(int, int, int)> pos = new List<(int, int, int)>();
            if (player == 0)
            {
                pos = [(6, 7, 8), (6, 10, 11), (7, 7, 8), (7, 10, 11)];
            }
            else if (player == 1)
            {
                pos = [(6, 34, 35), (6, 37, 38), (7, 34, 35), (7, 37, 38)];
            }
            else if (player == 2)
            {
                pos = [(24, 34, 35), (24, 37, 38), (25, 34, 35), (25, 37, 38)];
            }
            else
            {
                pos = [(24, 7, 8), (24, 10, 11), (25, 7, 8), (25, 10, 11)];
            }
            return pos;
        }

        //Getting Survived positions of players
        public (int,int,int) GetPositions(string guti)
        {
            int row,col;
            if (guti[0] == 'Y') row = 14;
            else if (guti[0] == 'G') row = 13;
            else if (guti[0] == 'B') row = 17;
            else row = 16;


            if (guti[1] == '1')
            {
                col = 19;
            }
            else if (guti[1] == '1')
            {
                col = 21;
            }
            else if (guti[1] == '1')
            {
                col = 23;
            }
            else
            {
                col = 25;
            }
            return (row, col, col + 1);
        }
        public (int, int, int) MoveGuti(int dice, string guti, (int, int, int) pos)
        {
            int row = pos.Item1, col1 = pos.Item2, col2 = pos.Item3;
            (int, int, int) position;
            while (dice > 0)
            {
                if (row > 12 && row < 18)
                {
                    if (col1 >= 1 && col1 < 19)
                    {
                        if (row == 13)
                        {
                            if (col1 == 16)
                            {
                                row -= 2;
                                col1 += 3;
                            }
                            else if (col1 < 16)
                            {
                                col1 += 3;
                            }
                            dice--;
                        }
                        else if (row == 15)
                        {
                            if (guti[0] == 'Y')
                            {
                                if (col1 + 3 * dice < 19)
                                {
                                    col1 = col1 + 3 * dice;
                                }
                                else if (col1 + 3 * dice == 19)
                                {
                                    position = GetPositions(guti);
                                    row = position.Item1;
                                    col1 = position.Item2;
                                }
                                dice -= dice;
                            }
                            else
                            {
                                row -= 2;
                                dice--;
                            }
                        }
                        else
                        {
                            if (col1 == 1)
                            {
                                row -= 2;
                            }
                            else if (col1 > 1)
                            {
                                col1 -= 3;
                            }
                            dice--;
                        }
                    }
                    else if (col1 >= 28 && col1 < 45)
                    {
                        if (row == 13)
                        {
                            if (col1 == 43)
                            {
                                row += 2;
                            }
                            else if (col1 < 45)
                            {
                                col1 += 3;
                            }
                            dice--;
                        }
                        else if (row == 15)
                        {
                            if (guti[0] == 'B')
                            {
                                if (col1 - 3 * dice > 25)
                                {
                                    col1 = col1 - 3 * dice;
                                }
                                else if (col1 + 3 * dice == 25)
                                {
                                    position = GetPositions(guti);
                                    row = position.Item1;
                                    col1 = position.Item2;
                                }
                                dice -= dice;
                            }
                            else
                            {
                                row += 2;
                                dice--;
                            }
                        }
                        else
                        {
                            if (col1 == 28)
                            {
                                row += 2;
                                col1 -= 3;
                            }
                            else if (col1 > 28)
                            {
                                col1 -= 3;
                            }
                            dice--;
                        }
                    }
                }
                else
                {
                    if (col1 > 18 && col1 < 27)
                    {
                        if (row > 0 && row < 12)
                        {
                            if (col1 == 19)
                            {
                                if (row == 1)
                                {
                                    col1 += 3;
                                }
                                else
                                {
                                    row -= 2;
                                }
                                dice--;
                               
                            }
                            else
                            {
                                if (col1 == 22)
                                {
                                    if (guti[0] == 'G')
                                    {
                                        if (row + 2 * dice < 13)
                                        {
                                            row = row + 2 * dice ;
                                        }
                                        else if (row + 2 * dice <= 13)
                                        {
                                            position = GetPositions(guti);
                                            row = position.Item1;
                                            col1 = position.Item2;
                                        }
                                        dice -= dice;
                                    }
                                    else
                                    {
                                        col1 += 3;
                                        dice--;
                                    }
                                }
                                else
                                {
                                    if (row == 11)
                                    {
                                        col1 += 3;
                                    }
                                    row += 2;
                                    dice--;
                                }
                                
                            }
                        }
                        else
                        {
                            if (col1 == 19)
                            {
                                if (row == 19)
                                {
                                    col1 -= 3;
                                }
                                row -= 2;
                                dice--;

                            }
                            else
                            {
                                if (col1 == 22)
                                {
                                    if (guti[0] == 'R')
                                    {
                                        if (row - 2 * dice > 17)
                                        {
                                            row = row - 2 * dice;
                                        }
                                        else if (row + 2 * dice >= 17)
                                        {
                                            position = GetPositions(guti);
                                            row = position.Item1;
                                            col1 = position.Item2;
                                        }
                                        dice -= dice;
                                    }
                                    else
                                    {
                                        col1 -= 3;
                                        dice--;
                                    }
                                }
                                else
                                {
                                    if (row == 29)
                                    {
                                        col1 -= 3;
                                    }
                                    else
                                    {
                                        row += 2;
                                    }
                                    dice--;
                                }

                            }
                        }
                    }
                }
            }

            return (row, col1, col1 + 1);
        }

        public void Display()
        {
            foreach (var line in board)
            {
                Console.WriteLine(line);
            }
        }
    }
}
