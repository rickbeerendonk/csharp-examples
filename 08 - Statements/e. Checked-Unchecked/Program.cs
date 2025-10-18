// European Union Public License version 1.2
// Copyright © 2025 Rick Beerendonk

// checked statement enables overflow checking for arithmetic operations
try
{
  checked
  {
    int max = int.MaxValue;
    Console.WriteLine($"Max value: {max}");
    int overflow = max + 1; // This will throw OverflowException
    Console.WriteLine($"Overflow: {overflow}");
  }
}
catch (OverflowException)
{
  Console.WriteLine("Overflow detected in checked block");
}

// unchecked statement disables overflow checking
unchecked
{
  int max = int.MaxValue;
  Console.WriteLine($"Max value: {max}");
  int overflow = max + 1; // This will wrap around
  Console.WriteLine($"Unchecked overflow: {overflow}");
}
