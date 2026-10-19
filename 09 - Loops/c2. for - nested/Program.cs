// Copyright © 2026 Rick Beerendonk

for (int row = 1; row <= 2; row++)
{
  for (int column = 1; column <= 3; column++)
  {
    if (column == 2) continue; // Only advances the inner loop.
    Console.WriteLine($"Row {row}, column {column}");
  }
}

// Row 1, column 1
// Row 1, column 3
// Row 2, column 1
// Row 2, column 3
