// European Union Public License version 1.2
// Copyright © 2025 Rick Beerendonk

using System.Collections.Concurrent;

var collection = new BlockingCollection<string>();

collection.Add("A");
collection.Add("B");
collection.Add("C");

string item = collection.Take(); // Blocks if empty

Console.WriteLine($"Took: {item}"); // A
Console.WriteLine($"Count: {collection.Count}"); // 2
