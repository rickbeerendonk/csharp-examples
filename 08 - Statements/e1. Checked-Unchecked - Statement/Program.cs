// European Union Public License version 1.2
// Copyright © 2026 Rick Beerendonk

int max = int.MaxValue;
Console.WriteLine($"Max value: {max}");

// Default behavior: Overflow checking depends on compiler settings

// Unchecked statement: overflow wraps around.
unchecked
{
  int wrapped = max + 1;
  Console.WriteLine($"Unchecked overflow: {wrapped}");
}

// Checked statement: overflow throws.
try
{
  checked
  {
    int overflow = max + 1;
    Console.WriteLine($"Checked overflow: {overflow}");
  }
}
catch (OverflowException)
{
  Console.WriteLine("Overflow detected");
}
