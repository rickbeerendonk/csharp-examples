// European Union Public License version 1.2
// Copyright © 2025 Rick Beerendonk

int x = 10;

// Increment
Console.WriteLine($"x = {x}");
Console.WriteLine($"x++ = {x++}"); // Post-increment: uses value then increments
Console.WriteLine($"x = {x}");

Console.WriteLine($"++x = {++x}"); // Pre-increment: increments then uses value
Console.WriteLine($"x = {x}");

// Decrement
Console.WriteLine($"x-- = {x--}"); // Post-decrement: uses value then decrements
Console.WriteLine($"x = {x}");

Console.WriteLine($"--x = {--x}"); // Pre-decrement: decrements then uses value
Console.WriteLine($"x = {x}");

// Output:
// x = 10
// x++ = 10
// x = 11
// ++x = 12
// x = 12
// x-- = 12
// x = 11
// --x = 10
// x = 10