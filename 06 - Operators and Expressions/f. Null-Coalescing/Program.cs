// European Union Public License version 1.2
// Copyright © 2025 Rick Beerendonk

string? name = null;
string defaultName = "Unknown";

// Null-coalescing operator (??)
string result = name ?? defaultName;
Console.WriteLine($"Result: {result}"); // Unknown

name = "Alexandra";
result = name ?? defaultName;
Console.WriteLine($"Result: {result}"); // Alexandra

// Null-coalescing assignment operator (??=)
string? greeting = null;
greeting ??= "Hello";
Console.WriteLine($"Greeting: {greeting}"); // Hello

greeting ??= "Hi";
Console.WriteLine($"Greeting: {greeting}"); // Hello (not changed)
