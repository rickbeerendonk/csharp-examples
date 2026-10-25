// Copyright © 2026 Rick Beerendonk

using System.Diagnostics.CodeAnalysis;

string?[] cities = [null, "Oslo"];

foreach (string? city in cities)
{
  // Console.WriteLine(city.Length); // This would cause a compiler warning because city might be null.
  if (HasText(city))
  {
    Console.WriteLine(city.Length); // The attribute makes this safe for the compiler.
  }
  else
  {
    Console.WriteLine("Missing city");
  }
}

// Attribute usage example
static bool HasText([NotNullWhen(true)] string? value)
{
  return !string.IsNullOrWhiteSpace(value);
}

// Missing city
// 4
