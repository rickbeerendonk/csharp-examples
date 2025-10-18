// European Union Public License version 1.2
// Copyright © 2025 Rick Beerendonk

using System.Collections.Concurrent;

var dict = new ConcurrentDictionary<string, int>();

Console.WriteLine(dict.Count); // 0
