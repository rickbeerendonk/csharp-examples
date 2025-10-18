// European Union Public License version 1.2
// Copyright © 2025 Rick Beerendonk

// String interpolation with formatting

double price = 123.456;
Console.WriteLine($"Price: {price:C}"); // Currency
Console.WriteLine($"Price: {price:F2}"); // Fixed-point with 2 decimals

int number = 42;
Console.WriteLine($"Number: {number:D5}"); // Decimal with 5 digits
Console.WriteLine($"Hex: {number:X}"); // Hexadecimal

DateTime now = DateTime.Now;
Console.WriteLine($"Date: {now:yyyy-MM-dd}");
Console.WriteLine($"Time: {now:HH:mm:ss}");
Console.WriteLine($"Full: {now:F}");

// Output:

// Price: $123.46
// Price: 123.46
// Number: 00042
// Hex: 2A
// Date: 2024-06-15
// Time: 14:30:45
// Full: Saturday, June 15, 2024 2:30:45 PM
