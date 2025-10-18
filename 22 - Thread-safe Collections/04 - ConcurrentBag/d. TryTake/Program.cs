// European Union Public License version 1.2
// Copyright © 2025 Rick Beerendonk

using System.Collections.Concurrent;

var bag = new ConcurrentBag<string>(["A", "B", "C"]);

if (bag.TryTake(out string? item))
{
  Console.WriteLine($"Took: {item}");
}

Console.WriteLine($"Count: {bag.Count}"); // 2

// Note: Order of removal is not guaranteed (unordered collection)
