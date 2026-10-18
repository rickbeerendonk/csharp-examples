// European Union Public License version 1.2
// Copyright © 2025 Rick Beerendonk

int Max = int.MaxValue;
Console.WriteLine($"Max value: {Max}");


// unchecked statement disables overflow checking
unchecked
{
  int overflow = Max + 1; // This will wrap around
  Console.WriteLine($"Unchecked overflow: {overflow}");
}

// checked statement enables overflow checking for arithmetic operations
try
{
  checked
  {
    int overflow = Max + 1; // This will throw OverflowException
    Console.WriteLine($"Overflow: {overflow}");
  }
}
catch (OverflowException)
{
  Console.WriteLine("Overflow detected in checked block");
}
