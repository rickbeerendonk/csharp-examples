// European Union Public License version 1.2
// Copyright © 2025 Rick Beerendonk

using System.Collections.Concurrent;

var dict = new ConcurrentDictionary<string, int>();

bool added1 = dict.TryAdd("A", 1);
bool added2 = dict.TryAdd("B", 2);
bool added3 = dict.TryAdd("A", 10); // Fails, "A" already exists

Console.WriteLine($"Added 'A': {added1}"); // True
Console.WriteLine($"Added 'B': {added2}"); // True
Console.WriteLine($"Added 'A' again: {added3}"); // False
Console.WriteLine($"Value of 'A': {dict["A"]}"); // 1
