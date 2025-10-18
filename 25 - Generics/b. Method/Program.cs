// European Union Public License version 1.2
// Copyright © 2025 Rick Beerendonk

// Generic methods

int maxInt = GetMax(10, 20);
Console.WriteLine($"Max int: {maxInt}");

string maxString = GetMax("apple", "banana");
Console.WriteLine($"Max string: {maxString}");

double maxDouble = GetMax(3.14, 2.71);
Console.WriteLine($"Max double: {maxDouble}");

T GetMax<T>(T a, T b) where T : IComparable<T>
{
  return a.CompareTo(b) > 0 ? a : b;
}
