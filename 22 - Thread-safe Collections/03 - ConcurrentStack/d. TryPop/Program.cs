// European Union Public License version 1.2
// Copyright © 2025 Rick Beerendonk

using System.Collections.Concurrent;

var stack = new ConcurrentStack<string>(["A", "B", "C"]);

if (stack.TryPop(out string? item))
{
  Console.WriteLine($"Popped: {item}"); // C
}

Console.WriteLine($"Count: {stack.Count}"); // 2
