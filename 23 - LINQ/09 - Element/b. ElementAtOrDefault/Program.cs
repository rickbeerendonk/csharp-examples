// Copyright (c) Rick Beerendonk. All rights reserved.
// Licensed under the MIT license.
// Example of LINQ ElementAtOrDefault
// .NET 9.0, C# 12, Nullable enabled

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        var numbers = Enumerable.Range(1, 5).ToArray();
        Console.WriteLine($"Element at index 2: {numbers.ElementAtOrDefault(2)}"); // 3
        Console.WriteLine($"Element at index 10: {numbers.ElementAtOrDefault(10)}"); // 0 (default for int)

        var words = new[] { "apple", "banana" };
        Console.WriteLine($"Element at index 1: {words.ElementAtOrDefault(1)}"); // banana
        Console.WriteLine($"Element at index 5: {words.ElementAtOrDefault(5) ?? "null"}"); // null
    }
}
