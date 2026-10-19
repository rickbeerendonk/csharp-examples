// European Union Public License version 1.2
// Copyright © 2025 Rick Beerendonk

int x = 10;
Console.WriteLine($"x = {x}"); // 10

x += 5; // x = x + 5
Console.WriteLine($"x += 5: {x}"); // 15

x -= 3; // x = x - 3
Console.WriteLine($"x -= 3: {x}"); // 12

x *= 2; // x = x * 2
Console.WriteLine($"x *= 2: {x}"); // 24

x /= 4; // x = x / 4
Console.WriteLine($"x /= 4: {x}"); // 6

x %= 3; // x = x % 3
Console.WriteLine($"x %= 3: {x}"); // 0

// Bitwise compound assignments.
int bits = 12;
bits &= 10;
Console.WriteLine(bits); // 8
bits |= 3;
Console.WriteLine(bits); // 11
bits ^= 1;
Console.WriteLine(bits); // 10
bits <<= 1;
Console.WriteLine(bits); // 20
bits >>= 1;
Console.WriteLine(bits); // 10
bits = -8;
bits >>>= 1;
Console.WriteLine(bits); // 2147483644
