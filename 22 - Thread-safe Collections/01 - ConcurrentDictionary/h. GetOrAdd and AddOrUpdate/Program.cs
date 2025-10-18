// European Union Public License version 1.2
// Copyright © 2025 Rick Beerendonk

using System.Collections.Concurrent;

var dict = new ConcurrentDictionary<string, int>();

// GetOrAdd: Gets existing value or adds new one
int valueA = dict.GetOrAdd("A", 1);
int valueA2 = dict.GetOrAdd("A", 10); // Gets existing value, doesn't add

Console.WriteLine($"First GetOrAdd 'A': {valueA}"); // 1
Console.WriteLine($"Second GetOrAdd 'A': {valueA2}"); // 1

// AddOrUpdate: Adds new value or updates existing one
int valueB = dict.AddOrUpdate("B", 2, (key, oldValue) => oldValue + 10);
int valueB2 = dict.AddOrUpdate("B", 2, (key, oldValue) => oldValue + 10);

Console.WriteLine($"First AddOrUpdate 'B': {valueB}"); // 2
Console.WriteLine($"Second AddOrUpdate 'B': {valueB2}"); // 12
