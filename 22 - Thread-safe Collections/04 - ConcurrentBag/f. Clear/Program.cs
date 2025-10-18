// European Union Public License version 1.2
// Copyright © 2025 Rick Beerendonk

using System.Collections.Concurrent;

var bag = new ConcurrentBag<int>([1, 2, 3]);

bag.Clear(); // Removes all elements

Console.WriteLine($"IsEmpty: {bag.IsEmpty}"); // True
