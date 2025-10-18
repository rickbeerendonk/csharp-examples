// European Union Public License version 1.2
// Copyright © 2025 Rick Beerendonk

using System.Collections.Concurrent;

var bag = new ConcurrentBag<string>(["A", "B", "C"]);

if (bag.TryPeek(out string? item))
{
  Console.WriteLine($"Peeked: {item}");
}

Console.WriteLine($"Count: {bag.Count}"); // 3 (not removed)

// Note: Order is not guaranteed (unordered collection)
