// European Union Public License version 1.2
// Copyright © 2025 Rick Beerendonk

using System.Collections.Immutable;

ImmutableSortedSet<int> set = [1, 2, 3, 4, 5].ToImmutableSortedSet();

int min = set.Min;
int max = set.Max;

Console.WriteLine($"Min: {min}"); // 1
Console.WriteLine($"Max: {max}"); // 5
