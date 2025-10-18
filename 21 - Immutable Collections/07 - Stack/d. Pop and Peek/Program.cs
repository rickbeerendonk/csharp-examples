// European Union Public License version 1.2
// Copyright © 2025 Rick Beerendonk

using System.Collections.Immutable;

ImmutableStack<string> stack = ImmutableStack.CreateRange(["A", "B", "C"]);

string top = stack.Peek(); // Returns "C" without removing
stack = stack.Pop(); // Removes "C"

Console.WriteLine($"Peeked: {top}");
Console.WriteLine($"Top after pop: {stack.Peek()}"); // B
