// European Union Public License version 1.2
// Copyright © 2022 Rick Beerendonk

// Explicit type
int expl = 123;

// Implicit type
var impl = 456;

Console.WriteLine(expl.GetType()); // System.Int32
Console.WriteLine(impl.GetType()); // System.Int32

// No error (as opposed to const)
expl = impl;

Console.WriteLine(expl); // 456
