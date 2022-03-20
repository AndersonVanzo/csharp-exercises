using System;

namespace TicTacToe
{
  class Program
  {
    static void Main(string[] args)
    {
      bool playing = true;
      int player = 1;
      int column, row;
      int[,] table = new int[,] {
        {0, 0, 0},
        {0, 0, 0},
        {0, 0, 0},
      };

      while (playing)
      {
        Console.Clear();
        Console.WriteLine("\n-- C# Tic-Tac-Toe --\n");
        PrintTable(table);
        Console.WriteLine("\nPlayer " + (player == 1 ? "X" : "O"));
        Console.Write("\nType the row number: ");
        row = Convert.ToInt16(Console.ReadLine()) - 1;

        Console.Write("Type the column number: ");
        column = Convert.ToInt16(Console.ReadLine()) - 1;

        if ((row > 0 && row < 4) && (column > 0 && column < 4))
        {
          if (table[row, column] != 0)
          {
            Console.WriteLine("\nOops! This position is already taken!\nPress any key to try again");
            Console.ReadKey();
          }
          else
          {
            table[row, column] = player;
            player = player == 1 ? 2 : 1;
            playing = CheckGame(table);
          }
        }
        else
        {
          Console.WriteLine("\nOops! Enter a valid option!\nPress any key to try again");
          Console.ReadKey();
        }
      }
    }

    static void PrintTable(int[,] table)
    {
      Console.WriteLine("  1 2 3");
      for (int x = 0; x < 3; x++)
      {
        Console.Write((x + 1) + "|");
        for (int y = 0; y < 3; y++)
        {
          if (table[x, y] == 0)
          {
            Console.Write(" |");
          }
          else if (table[x, y] == 1)
          {
            Console.Write("X|");
          }
          else
          {
            Console.Write("O|");
          }
        }
        Console.WriteLine("");
      }
    }

    static bool CheckGame(int[,] table)
    {
      int winner = 0;
      if (table[0, 0] != 0 && table[0, 0] == table[0, 1] && table[0, 1] == table[1, 2])
      {
        winner = table[0, 0];
      }
      else if (table[1, 0] != 0 && table[1, 0] == table[1, 1] && table[1, 1] == table[1, 2])
      {
        winner = table[1, 0];
      }
      else if (table[2, 0] != 0 && table[2, 0] == table[2, 1] && table[2, 1] == table[2, 2])
      {
        winner = table[2, 0];
      }
      else if (table[0, 0] != 0 && table[0, 0] == table[1, 0] && table[1, 0] == table[2, 0])
      {
        winner = table[0, 0];
      }
      else if (table[1, 0] != 0 && table[1, 0] == table[1, 1] && table[1, 1] == table[1, 2])
      {
        winner = table[1, 0];
      }
      else if (table[2, 0] != 0 && table[2, 0] == table[2, 1] && table[2, 1] == table[2, 2])
      {
        winner = table[2, 0];
      }
      else if (table[0, 0] != 0 && table[0, 0] == table[1, 1] && table[1, 1] == table[2, 2])
      {
        winner = table[0, 0];
      }
      else if (table[0, 2] != 0 && table[0, 2] == table[1, 1] && table[1, 1] == table[2, 0])
      {
        winner = table[0, 2];
      }
      else
      {
        return true;
      }

      Console.WriteLine("\nO jogador " + (winner == 1 ? "X" : "O") + " venceu!!!");
      Console.WriteLine("\n-- Fim de jogo! --\n");
      return false;
    }
  }
}