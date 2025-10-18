// European Union Public License version 1.2
// Copyright © 2025 Rick Beerendonk

int age = 20;

// Ternary operator (condition ? trueValue : falseValue)
string status = age >= 18 ? "Adult" : "Minor";
Console.WriteLine($"Age: {age}, Status: {status}");

age = 15;
status = age >= 18 ? "Adult" : "Minor";
Console.WriteLine($"Age: {age}, Status: {status}");
