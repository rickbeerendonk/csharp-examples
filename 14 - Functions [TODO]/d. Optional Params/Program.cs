// European Union Public License version 1.2
// Copyright © 2025 Rick Beerendonk

Test("Hello C#", 12);

void Test(string text, int number = 1, bool boolean = true)
{
  Console.WriteLine(text);
  Console.WriteLine(number);
  Console.WriteLine(boolean);
}

// Hello C#
// 12
// True