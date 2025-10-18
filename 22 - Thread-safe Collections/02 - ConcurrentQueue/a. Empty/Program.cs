// European Union Public License version 1.2
// Copyright © 2025 Rick Beerendonk

using System.Collections.Concurrent;

var queue = new ConcurrentQueue<string>();

Console.WriteLine(queue.IsEmpty); // True
