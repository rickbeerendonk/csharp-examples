// European Union Public License version 1.2
// Copyright © 2025 Rick Beerendonk

// Basic string interpolation

string name = "Rick";
int age = 30;

Console.WriteLine($"My name is {name} and I am {age} years old.");

// Expressions in interpolation
Console.WriteLine($"Next year I will be {age + 1} years old.");

// Method calls in interpolation
Console.WriteLine($"Uppercase name: {name.ToUpper()}");
