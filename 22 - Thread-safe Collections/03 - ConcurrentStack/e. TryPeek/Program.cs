// European Union Public License version 1.2
// Copyright © 2025 Rick Beerendonk

using System.Collections.Concurrent;

var stack = new ConcurrentStack<string>(["A", "B", "C"]);

if (stack.TryPeek(out string? item))
{
  Console.WriteLine($"Peeked: {item}"); // C
}

Console.WriteLine($"Count: {stack.Count}"); // 3 (not removed)
