// Copyright © 2026 Rick Beerendonk

// Multiple initializers and iterators.
for (int left = 0, right = 2; left < 3; left++, right--)
{
  Console.WriteLine($"{left}, {right}");
}

// 0, 2
// 1, 1
// 2, 0
