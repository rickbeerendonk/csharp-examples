// European Union Public License version 1.2
// Copyright © 2025 Rick Beerendonk

using System.Numerics;

// No min or max values for BigInteger
Console.WriteLine(BigInteger.MinusOne * BigInteger.Pow(2, 99)); // -633825300114114700748351602688
Console.WriteLine(BigInteger.Pow(2, 99)); // 633825300114114700748351602688

// Explicit vs Implicit
BigInteger explicitValue = BigInteger.Parse("999000999000");
var implicitValue = BigInteger.Parse("999000999000");

Console.WriteLine(explicitValue.GetType().FullName); // System.Numerics.BigInteger
Console.WriteLine(implicitValue.GetType().FullName); // System.Numerics.BigInteger

// Arithmetic
BigInteger a = BigInteger.Parse("2");
BigInteger b = BigInteger.Parse("3");

Console.WriteLine(BigInteger.Add(a, b));         // 5
Console.WriteLine(BigInteger.Subtract(b, a));    // 1
Console.WriteLine(BigInteger.Multiply(a, b));    // 6
Console.WriteLine(BigInteger.Divide(b, a));      // 1

// Absolute value
Console.WriteLine(BigInteger.Abs(BigInteger.MinusOne));  // 1

// Zero, One, Max, Min
Console.WriteLine(BigInteger.Zero);              // 0
Console.WriteLine(BigInteger.One);               // 1
Console.WriteLine(BigInteger.Max(a, b));         // 3
Console.WriteLine(BigInteger.Min(a, b));         // 2

// TryParse
if (BigInteger.TryParse("123", out BigInteger parsed))
    Console.WriteLine(parsed);                   // 123

// Compare, Equals, Sign
Console.WriteLine(BigInteger.Compare(a, b));     // -1 if a < b
Console.WriteLine(a.Equals(2));                  // True
Console.WriteLine(a.Sign);                       // 1 for positive

// IsEven, IsPowerOfTwo
Console.WriteLine(a.IsEven);                     // True
Console.WriteLine(BigInteger.One.IsPowerOfTwo);  // True

// GreatestCommonDivisor
Console.WriteLine(BigInteger.GreatestCommonDivisor(100, 330)); // 10

// Log, Log10
Console.WriteLine(BigInteger.Log(a));            // 0.6931471805599453
Console.WriteLine(BigInteger.Log10(a));          // 0.30102999566398114
