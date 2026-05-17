// European Union Public License version 1.2
// Copyright © 2026 Rick Beerendonk

// Nullable value types

int? nullableInt = null;
PrintValues(nullableInt);

nullableInt = 42;
PrintValues(nullableInt);

void PrintValues(int? value)
{
  Console.WriteLine($"HasValue: {value.HasValue}");
  Console.WriteLine($"Value: {value?.ToString()}");
  Console.WriteLine($"GetValueOrDefault: {value.GetValueOrDefault()}");
  Console.WriteLine();
}

// HasValue: False
// Value:
// GetValueOrDefault: 0
//
// HasValue: True
// Value: 42
// GetValueOrDefault: 42
