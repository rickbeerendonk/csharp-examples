// European Union Public License version 1.2
// Copyright © 2025 Rick Beerendonk

// try-catch handles exceptions

try
{
  int[] numbers = { 1, 2, 3 };
  Console.WriteLine(numbers[10]); // This will throw IndexOutOfRangeException
}
catch (IndexOutOfRangeException ex)
{
  Console.WriteLine($"Caught exception: {ex.Message}");
}

Console.WriteLine("Program continues...");
