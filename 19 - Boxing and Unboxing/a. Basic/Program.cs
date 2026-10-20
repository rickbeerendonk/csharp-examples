// European Union Public License version 1.2
// Copyright © 2025 Rick Beerendonk

// Boxing - converting value type to reference type

int value = 42;
Console.WriteLine($"Value type: {value}");

// Boxing: value type → reference type (object)
object boxed = value;
Console.WriteLine($"Boxed: {boxed}");

// Unboxing: reference type (object) → value type
int unboxed = (int)boxed;
Console.WriteLine($"Unboxed: {unboxed}");

// Value type: 42
// Boxed: 42
// Unboxed: 42

// We can proof boxing happens by comparing the reference of the boxed object with the original value.
Console.WriteLine($"ReferenceEquals(value, boxed): {ReferenceEquals(value, boxed)}"); // False
