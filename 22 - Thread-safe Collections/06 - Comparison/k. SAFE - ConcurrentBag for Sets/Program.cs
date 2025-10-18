// European Union Public License version 1.2
// Copyright © 2025 Rick Beerendonk

using System.Collections.Concurrent;

// SAFE: ConcurrentBag works correctly with parallel operations
var safeBag = new ConcurrentBag<int>();

Console.WriteLine("Parallel operations with SAFE ConcurrentBag");
Console.WriteLine("===========================================");
Console.WriteLine();

// Multiple threads adding items
Parallel.For(0, 1000, i =>
{
  safeBag.Add(i);
});

Console.WriteLine($"Expected count: 1000");
Console.WriteLine($"Actual count: {safeBag.Count}");

// Verify all items are present
var items = safeBag.ToList();
bool allPresent = Enumerable.Range(0, 1000).All(i => items.Contains(i));

Console.WriteLine($"All items present: {allPresent}");
Console.WriteLine("✅ All operations completed successfully!");
