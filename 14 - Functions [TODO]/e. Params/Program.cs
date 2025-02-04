// European Union Public License version 1.2
// Copyright © 2025 Rick Beerendonk

Test("Hello C#", 1, 2, 3, 4);

void Test(string text, params int[] numbers)
{
  Console.WriteLine(text);
  foreach (var number in numbers)
  {
    Console.WriteLine(number);
  }
}

// Hello C#
// 1
// 2
// 3
// 4