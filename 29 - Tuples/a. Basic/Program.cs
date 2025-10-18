// European Union Public License version 1.2
// Copyright © 2025 Rick Beerendonk

// Basic tuple literals

var tuple = (1, "Hello", true);
Console.WriteLine($"Item1: {tuple.Item1}");
Console.WriteLine($"Item2: {tuple.Item2}");
Console.WriteLine($"Item3: {tuple.Item3}");

// Tuple with explicit types
(int number, string text, bool flag) typedTuple = (42, "World", false);
Console.WriteLine($"Number: {typedTuple.number}");
Console.WriteLine($"Text: {typedTuple.text}");
Console.WriteLine($"Flag: {typedTuple.flag}");
