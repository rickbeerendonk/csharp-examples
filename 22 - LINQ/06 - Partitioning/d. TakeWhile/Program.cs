﻿// European Union Public License version 1.2
// Copyright © 2025 Rick Beerendonk

IEnumerable<string> names = ["Alice", "Bob", "Charlie", "David", "Eve", "Frank"];

var namesResult = names.TakeWhile(name => name.Length <= 5);

foreach (var name in namesResult)
{
    Console.WriteLine(name);
}

// Alice
// Bob