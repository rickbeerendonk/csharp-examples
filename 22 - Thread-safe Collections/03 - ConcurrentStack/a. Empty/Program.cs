// European Union Public License version 1.2
// Copyright © 2025 Rick Beerendonk

using System.Collections.Concurrent;

var stack = new ConcurrentStack<string>();

Console.WriteLine(stack.IsEmpty); // True
