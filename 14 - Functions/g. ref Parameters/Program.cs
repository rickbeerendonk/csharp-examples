// European Union Public License version 1.2
// Copyright © 2025 Rick Beerendonk

// ref parameters pass by reference

int number = 10;
Console.WriteLine($"Before: {number}");

DoubleValue(ref number);
Console.WriteLine($"After: {number}");

void DoubleValue(ref int value)
{
  value *= 2;
}
