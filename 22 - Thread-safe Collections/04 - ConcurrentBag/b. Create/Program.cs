// European Union Public License version 1.2
// Copyright © 2025 Rick Beerendonk

using System.Collections.Concurrent;

var bag = new ConcurrentBag<string>(["A", "B", "C"]);

Console.WriteLine(bag.Count); // 3
