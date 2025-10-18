// European Union Public License version 1.2
// Copyright © 2025 Rick Beerendonk

using System.Collections.Immutable;

ImmutableStack<string> stack = ImmutableStack.CreateRange(["A", "B", "C"]);

Console.WriteLine(stack.IsEmpty); // False
