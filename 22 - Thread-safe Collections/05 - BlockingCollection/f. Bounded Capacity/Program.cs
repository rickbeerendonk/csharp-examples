// European Union Public License version 1.2
// Copyright © 2025 Rick Beerendonk

using System.Collections.Concurrent;

// Create with bounded capacity of 2
var collection = new BlockingCollection<string>(2);

collection.Add("A");
collection.Add("B");

// This would block because capacity is full
bool added = collection.TryAdd("C", 100); // Timeout after 100ms

Console.WriteLine($"Added 'C': {added}"); // False
Console.WriteLine($"Count: {collection.Count}"); // 2
