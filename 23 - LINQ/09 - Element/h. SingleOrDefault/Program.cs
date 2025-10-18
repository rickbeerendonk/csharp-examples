// Copyright (c) Rick Beerendonk. All rights reserved.
// Licensed under the MIT license.
// Example of LINQ SingleOrDefault
// .NET 9.0, C# 12, Nullable enabled

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        var numbers = new[] { 42 };
        Console.WriteLine($"SingleOrDefault: {numbers.SingleOrDefault()}"); // 42
        var empty = Array.Empty<int>();
        Console.WriteLine($"SingleOrDefault (empty): {empty.SingleOrDefault()}"); // 0
        // Throws if more than one element
        try
        {
            var many = new[] { 1, 2 };
            Console.WriteLine(many.SingleOrDefault());
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine($"Exception: {ex.GetType().Name}");
        }
    }
}
