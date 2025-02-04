// European Union Public License version 1.2
// Copyright © 2025 Rick Beerendonk

Utils.Test("Hello C#");
Utils.Test(123);
Utils.Test(1, 2);

// Overloaded functions must be part of a class.
static class Utils
{
  public static void Test(string text)
  {
    Console.WriteLine(text);
  }

  public static void Test(int number)
  {
    Console.WriteLine(number);
  }

  public static void Test(int number1, int number2)
  {
    Console.WriteLine(number1);
    Console.WriteLine(number2);
  }
}

// Hello C#
// 123
// 1
// 2