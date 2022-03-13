using System;

namespace BasicCalculator
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("\n-- C# Basic Calculator --");
      Console.WriteLine("\nSelect an option:");
      Console.WriteLine(" 1 - Sum\n 2 - Subtraction\n 3 - Multiplication\n 4 - Division");

      int option = Convert.ToInt16(Console.ReadLine());

      if (option <= 0 || option >= 5)
      {
        Console.WriteLine("Invalid option!");
      }
      else
      {
        Console.Write("\nType the first number: ");
        float num1 = Convert.ToSingle(Console.ReadLine());

        Console.Write("\nType the second number: ");
        float num2 = Convert.ToSingle(Console.ReadLine());

        float result = 0;
        if (option == 1)
        {
          result = num1 + num2;
        }
        else if (option == 2)
        {
          result = num1 - num2;
        }
        else if (option == 3)
        {
          result = num1 * num2;
        }
        else if (option == 4)
        {
          result = num1 / num2;
        }

        Console.WriteLine("\nThe result is: " + result);
      }
    }
  }
}