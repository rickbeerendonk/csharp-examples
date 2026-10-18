// European Union Public License version 1.2
// Copyright © 2026 Rick Beerendonk

const int iterations = 1_000_000;
object lockObject = new();
int countWithoutLock = 0;
int countWithLock = 0;

Parallel.For(0, iterations, _ =>
{
  // Without lock: multiple threads can update the counter concurrently.
  countWithoutLock++;

  // With lock: only one thread at a time can execute this block.
  // All threads must use the same lock object to protect the counter.
  lock (lockObject)
  {
    countWithLock++;
  }
});

Console.WriteLine($"Without lock: {countWithoutLock} (expected: {iterations})");
Console.WriteLine($"With lock:    {countWithLock} (expected: {iterations})");
