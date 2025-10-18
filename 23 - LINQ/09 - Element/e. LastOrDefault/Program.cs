// Copyright (c) Rick Beerendonk. All rights reserved.
// Licensed under the MIT license.
// Example of LINQ LastOrDefault
// .NET 9.0, C# 12, Nullable enabled

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        var numbers = new int[] { 1, 2, 3 };
        Console.WriteLine($"LastOrDefault: {numbers.LastOrDefault()}"); // 3
        var empty = Array.Empty<int>();
        Console.WriteLine($"LastOrDefault (empty): {empty.LastOrDefault()}"); // 0
    }
}
