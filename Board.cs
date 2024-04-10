using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProj;

internal class Board
{
    public string[,] array = new string[8, 8];
    public int a = 0;
    /// <summary>
    /// Creates and prints the chess board
    /// </summary>
    public void CreateBoard(Coordinates startCoord, Coordinates endCoord)
    {
        int startNum = startCoord.number;
        int endNum = endCoord.number;
        Letters startLetter = startCoord.letter;
        Letters endLetter = endCoord.letter;
        PrintLettersNextToBoard();
        for (int i = 0; i < 8; i++)
        {
            PrintNumbersNextToBoard();
            for (int j = 0; j < 8; j++)
            {
                if ((i + j) % 2 == 0)
                {
                    Console.BackgroundColor = ConsoleColor.DarkGray;
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                }

                if (i == startNum - 1 && j == (int)startLetter)
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write(" K ");
                }
                else if (i == endNum - 1 && j == (int)endLetter)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write(" K ");
                }
                else
                {
                    Console.Write("   ");
                }

            }
            Console.ResetColor();
            Console.WriteLine();
        }
    }
    /// <summary>
    /// Prints numbers next to the board(1-8)
    /// </summary>
    public void PrintNumbersNextToBoard()
    {
        Console.Write(++a + " ");
    }
    /// <summary>
    /// Prints letters next to the board (A-H)
    /// </summary>
    public void PrintLettersNextToBoard()
    {
        for (char k = 'A'; k <= 'H'; k++)
        {
            if (k == 'A')
            {
                Console.Write("  ");
            }
            Console.Write(" " + k + " ");
        }
        Console.WriteLine();
    }
}

