// European Union Public License version 1.2
// Copyright © 2025 Rick Beerendonk

int a = 12; // 1100 in binary
int b = 10; // 1010 in binary

Console.WriteLine($"AND: {a} & {b} = {a & b}"); // 1000 = 8
Console.WriteLine($"OR: {a} | {b} = {a | b}"); // 1110 = 14
Console.WriteLine($"XOR: {a} ^ {b} = {a ^ b}"); // 0110 = 6
Console.WriteLine($"NOT: ~{a} = {~a}"); // Inverts all bits
Console.WriteLine($"Left Shift: {a} << 1 = {a << 1}"); // 11000 = 24
Console.WriteLine($"Right Shift: {a} >> 1 = {a >> 1}"); // 110 = 6
