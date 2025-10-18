// European Union Public License version 1.2
// Copyright © 2025 Rick Beerendonk

// UNSAFE: Regular HashSet is NOT thread-safe
var unsafeSet = new HashSet<int>();

Console.WriteLine("Parallel operations with UNSAFE HashSet");
Console.WriteLine("=======================================");
Console.WriteLine();

try
{
  // Multiple threads adding items
  Parallel.For(0, 1000, i =>
  {
    unsafeSet.Add(i); // Race condition
  });

  Console.WriteLine($"Expected count: 1000");
  Console.WriteLine($"Actual count: {unsafeSet.Count}");

  if (unsafeSet.Count != 1000)
  {
    Console.WriteLine("❌ Data loss - some items were lost!");
  }

  // Try to use the set
  bool contains = unsafeSet.Contains(500);
  Console.WriteLine($"Contains 500: {contains}");
}
catch (Exception ex)
{
  Console.WriteLine($"❌ Exception: {ex.GetType().Name}");
  Console.WriteLine($"   Message: {ex.Message}");
  Console.WriteLine();
  Console.WriteLine("Common exceptions:");
  Console.WriteLine("- InvalidOperationException: Collection modified during enumeration");
  Console.WriteLine("- ArgumentException: Item already added (race condition)");
  Console.WriteLine("- NullReferenceException: Corrupted internal state");
}
