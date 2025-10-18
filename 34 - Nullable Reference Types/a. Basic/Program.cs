// European Union Public License version 1.2
// Copyright © 2025 Rick Beerendonk

// Nullable reference types

// Non-nullable string (cannot be null)
string name = "Alexandra";
Console.WriteLine($"Name: {name}");

// Nullable string (can be null)
string? nullableName = null;
Console.WriteLine($"Nullable name: {nullableName ?? "No name"}");

nullableName = "Bob";
Console.WriteLine($"Nullable name: {nullableName}");

// Warning if trying to assign null to non-nullable
// name = null; // Uncomment to see warning

// Output:

// Name: Alexandra
// Nullable name: No name
// Nullable name: Bob
