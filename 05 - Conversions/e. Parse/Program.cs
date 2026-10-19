// Copyright © 2026 Rick Beerendonk

using System.Globalization;

Console.WriteLine($"Boolean: {bool.Parse("true")}");
Console.WriteLine($"Byte: {byte.Parse("18", CultureInfo.InvariantCulture)}");
Console.WriteLine($"SByte: {sbyte.Parse("18", CultureInfo.InvariantCulture)}");
Console.WriteLine($"Short: {short.Parse("18", CultureInfo.InvariantCulture)}");
Console.WriteLine($"UShort: {ushort.Parse("18", CultureInfo.InvariantCulture)}");
Console.WriteLine($"Int: {int.Parse("18", CultureInfo.InvariantCulture)}");
Console.WriteLine($"UInt: {uint.Parse("18", CultureInfo.InvariantCulture)}");
Console.WriteLine($"Long: {long.Parse("18", CultureInfo.InvariantCulture)}");
Console.WriteLine($"ULong: {ulong.Parse("18", CultureInfo.InvariantCulture)}");
Console.WriteLine($"Float: {float.Parse("18.9", CultureInfo.InvariantCulture)}");
Console.WriteLine($"Double: {double.Parse("18.9", CultureInfo.InvariantCulture)}");
Console.WriteLine($"Decimal: {decimal.Parse("18.9", CultureInfo.InvariantCulture)}");
Console.WriteLine($"Char: {char.Parse("A")}");
Console.WriteLine($"BigInteger: {System.Numerics.BigInteger.Parse("18", CultureInfo.InvariantCulture)}");
Console.WriteLine($"nint: {nint.Parse("18", CultureInfo.InvariantCulture)}");
Console.WriteLine($"nuint: {nuint.Parse("18", CultureInfo.InvariantCulture)}");

try
{
  int.Parse("eighteen", CultureInfo.InvariantCulture);
}
catch (FormatException ex)
{
  Console.WriteLine(ex.Message); // The input string 'eighteen' was not in a correct format.
}
