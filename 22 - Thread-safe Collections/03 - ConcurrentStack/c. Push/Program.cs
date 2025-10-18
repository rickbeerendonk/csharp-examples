// European Union Public License version 1.2
// Copyright © 2025 Rick Beerendonk

using System.Collections.Concurrent;

var stack = new ConcurrentStack<string>(["A", "B"]);

stack.Push("C"); // Adds to the top
stack.Push("D"); // Adds to the top

foreach (string item in stack)
{
  Console.WriteLine(item);
}

// D
// C
// B
// A
