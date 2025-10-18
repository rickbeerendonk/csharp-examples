// European Union Public License version 1.2
// Copyright © 2025 Rick Beerendonk

// Basic string interpolation

string name = "Alexandra";
int age = 34;

Console.WriteLine($"My name is {name} and I am {age} years old.");

// Expressions in interpolation
Console.WriteLine($"Next year I will be {age + 1} years old.");

// Method calls in interpolation
Console.WriteLine($"Uppercase name: {name.ToUpper()}");

// Output:

// My name is Alexandra and I am 34 years old.
// Next year I will be 35 years old.
// Uppercase name: ALEXANDRA
