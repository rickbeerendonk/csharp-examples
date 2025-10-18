// Copyright (c) Rick Beerendonk. All rights reserved.
// Licensed under the MIT license.
// Example of LINQ ElementAt
// .NET 9.0, C# 12, Nullable enabled

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        var numbers = Enumerable.Range(1, 5).ToArray();
        Console.WriteLine($"Element at index 2: {numbers.ElementAt(2)}"); // 3
        // Throws if index is out of range
        try
        {
            Console.WriteLine(numbers.ElementAt(10));
        }
        catch (ArgumentOutOfRangeException ex)
        {
            Console.WriteLine($"Exception: {ex.GetType().Name}");
        }
    }
}
