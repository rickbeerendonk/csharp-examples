// Copyright © 2026 Rick Beerendonk

var range = GetRange([4, 5, 3]);
Console.WriteLine($"Minimum: {range.Minimum}, maximum: {range.Maximum}");

static (int Minimum, int Maximum) GetRange(int[] readings)
{
  return (readings.Min(), readings.Max());
}

// Minimum: 3, maximum: 5
