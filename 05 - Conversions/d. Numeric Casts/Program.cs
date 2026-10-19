// Copyright © 2026 Rick Beerendonk

const int originalInt = 18;

// int -> double / decimal (widening conversion)
Console.WriteLine("\nint -> double / decimal");

double widenedDouble = originalInt; // An implicit widening conversion.
decimal widenedDecimal = originalInt; // An implicit widening conversion.
Console.WriteLine(widenedDouble); // 18
Console.WriteLine(widenedDecimal); // 18

// double -> int (narrowing conversion)
Console.WriteLine("\ndouble -> int (narrowing conversion)");

const double originalDouble = 18.9;
int truncated = (int)originalDouble; // A cast truncates towards zero.
int rounded = Convert.ToInt32(originalDouble); // Convert rounds instead.
Console.WriteLine(truncated); // 18
Console.WriteLine(rounded);   // 19

// decimal -> int (narrowing conversion)
Console.WriteLine("\ndecimal -> int (narrowing conversion)");

const decimal originalDecimal = 18.9m;
int truncatedDecimal = (int)originalDecimal; // A cast truncates towards zero.
int roundedDecimal = Convert.ToInt32(originalDecimal); // Convert rounds instead.
Console.WriteLine(truncatedDecimal); // 18
Console.WriteLine(roundedDecimal);   // 19
