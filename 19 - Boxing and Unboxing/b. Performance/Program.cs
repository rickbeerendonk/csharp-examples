// European Union Public License version 1.2
// Copyright © 2025 Rick Beerendonk

// Performance impact of boxing

using System.Diagnostics;

const int iterations = 10_000_000;

// Value-type arithmetic.
long directTotal = 0;
Stopwatch direct = Stopwatch.StartNew();
for (int i = 0; i < iterations; i++)
  directTotal += i + 1;
direct.Stop();

// Boxing and unboxing each value.
long boxedTotal = 0;
Stopwatch boxed = Stopwatch.StartNew();
for (int i = 0; i < iterations; i++)
{
  object value = i;
  boxedTotal += (int)value + 1;
}
boxed.Stop();
Console.WriteLine($"Without boxing: {direct.ElapsedMilliseconds} ms (total {directTotal})");
Console.WriteLine($"With boxing: {boxed.ElapsedMilliseconds} ms (total {boxedTotal})");
