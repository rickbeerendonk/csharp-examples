// European Union Public License version 1.2
// Copyright © 2025 Rick Beerendonk

using System.Collections.Concurrent;

var dict = new ConcurrentDictionary<string, int>();
dict["A"] = 1;
dict["B"] = 2;
dict["C"] = 3;

bool removed = dict.TryRemove("B", out int value);

Console.WriteLine($"Removed: {removed}"); // True
Console.WriteLine($"Value removed: {value}"); // 2
Console.WriteLine($"Count: {dict.Count}"); // 2
