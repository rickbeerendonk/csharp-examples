// European Union Public License version 1.2
// Copyright © 2022 Rick Beerendonk

// Explicit type
const int expl = 123;

Console.WriteLine(expl.GetType()); // System.Int32

// Error: The left-hand side of an assignment must be a variable, property or indexer
//expl = 456;