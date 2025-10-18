// European Union Public License version 1.2
// Copyright © 2025 Rick Beerendonk

// try-catch-finally combines exception handling and cleanup

try
{
  Console.WriteLine("Opening file...");
  int result = 10 / 0; // This will throw DivideByZeroException
  Console.WriteLine($"Result: {result}");
}
catch (DivideByZeroException ex)
{
  Console.WriteLine($"Error: {ex.Message}");
}
finally
{
  Console.WriteLine("Closing file (cleanup)...");
}

Console.WriteLine("Program continues...");
