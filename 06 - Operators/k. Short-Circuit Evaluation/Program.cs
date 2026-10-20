// Copyright © 2026 Rick Beerendonk

bool enabled = false;
int checks = 0;

bool result = enabled && ++checks > 0; // Skips the right operand.
Console.WriteLine($"&& : {result}, checks: {checks}");

checks = 0;
result = enabled & ++checks > 0; // Evaluates both operands.
Console.WriteLine($"&  : {result}, checks: {checks}");

enabled = true;
checks = 0;
result = enabled || ++checks > 0; // Skips the right operand.
Console.WriteLine($"|| : {result}, checks: {checks}");

checks = 0;
result = enabled | ++checks > 0; // Evaluates both operands.
Console.WriteLine($"|  : {result}, checks: {checks}");

Console.WriteLine($"XOR: {true ^ true}"); // True only when operands differ.

// &&: False, checks: 0
// &: False, checks: 1
// ||: True, checks: 0
// |: True, checks: 1
// XOR: False
