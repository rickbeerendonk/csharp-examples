// European Union Public License version 1.2
// Copyright © 2025 Rick Beerendonk

// Basic tuple literals

var tuple = (1, "Hello", true);
Console.WriteLine($"Item1: {tuple.Item1}"); // Item1: 1
Console.WriteLine($"Item2: {tuple.Item2}"); // Item2: Hello
Console.WriteLine($"Item3: {tuple.Item3}"); // Item3: True

// Tuple with explicit types
(int number, string text, bool flag) typedTuple = (42, "World", false);
Console.WriteLine($"Number: {typedTuple.number}"); // Number: 42
Console.WriteLine($"Text: {typedTuple.text}"); // Text: World
Console.WriteLine($"Flag: {typedTuple.flag}"); // Flag: False
