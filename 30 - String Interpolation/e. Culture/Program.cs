// Copyright © 2026 Rick Beerendonk

using System.Globalization;

decimal price = 18.5m;

Console.WriteLine(string.Create(
  CultureInfo.GetCultureInfo("nl-NL"), $"Price: {price:F2}"));

// Invariant formatting is useful for machine-readable output.
Console.WriteLine(FormattableString.Invariant($"Price: {price:F2}"));

// Price: 18,50
// Price: 18.50
