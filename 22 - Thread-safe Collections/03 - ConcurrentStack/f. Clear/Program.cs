// European Union Public License version 1.2
// Copyright © 2025 Rick Beerendonk

using System.Collections.Concurrent;

var stack = new ConcurrentStack<int>([1, 2, 3]);

stack.Clear(); // Removes all elements

Console.WriteLine($"IsEmpty: {stack.IsEmpty}"); // True
