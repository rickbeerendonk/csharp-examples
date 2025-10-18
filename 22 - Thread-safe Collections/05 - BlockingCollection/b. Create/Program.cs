// European Union Public License version 1.2
// Copyright © 2025 Rick Beerendonk

using System.Collections.Concurrent;

// Create with default underlying ConcurrentQueue
var collection = new BlockingCollection<string>();

collection.Add("A");
collection.Add("B");
collection.Add("C");

Console.WriteLine(collection.Count); // 3
