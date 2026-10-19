// Copyright © 2026 Rick Beerendonk

using System.Globalization;
using System.Numerics;

bool result;

// Success

result = bool.TryParse("true", out bool boolValue);
Console.WriteLine($"Result: {result}, Boolean: {boolValue}");
result = byte.TryParse("18", NumberStyles.Integer, CultureInfo.InvariantCulture, out byte byteValue);
Console.WriteLine($"Result: {result}, Byte: {byteValue}");
result = sbyte.TryParse("18", NumberStyles.Integer, CultureInfo.InvariantCulture, out sbyte sbyteValue);
Console.WriteLine($"Result: {result}, SByte: {sbyteValue}");
result = short.TryParse("18", NumberStyles.Integer, CultureInfo.InvariantCulture, out short shortValue);
Console.WriteLine($"Result: {result}, Short: {shortValue}");
result = ushort.TryParse("18", NumberStyles.Integer, CultureInfo.InvariantCulture, out ushort ushortValue);
Console.WriteLine($"Result: {result}, UShort: {ushortValue}");
result = int.TryParse("18", NumberStyles.Integer, CultureInfo.InvariantCulture, out int intValue);
Console.WriteLine($"Result: {result}, Int: {intValue}");
result = uint.TryParse("18", NumberStyles.Integer, CultureInfo.InvariantCulture, out uint uintValue);
Console.WriteLine($"Result: {result}, UInt: {uintValue}");
result = long.TryParse("18", NumberStyles.Integer, CultureInfo.InvariantCulture, out long longValue);
Console.WriteLine($"Result: {result}, Long: {longValue}");
result = ulong.TryParse("18", NumberStyles.Integer, CultureInfo.InvariantCulture, out ulong ulongValue);
Console.WriteLine($"Result: {result}, ULong: {ulongValue}");
result = float.TryParse("18.9", NumberStyles.Float, CultureInfo.InvariantCulture, out float floatValue);
Console.WriteLine($"Result: {result}, Float: {floatValue}");
result = double.TryParse("18.9", NumberStyles.Float, CultureInfo.InvariantCulture, out double doubleValue);
Console.WriteLine($"Result: {result}, Double: {doubleValue}");
result = decimal.TryParse("18.9", NumberStyles.Number, CultureInfo.InvariantCulture, out decimal decimalValue);
Console.WriteLine($"Result: {result}, Decimal: {decimalValue}");
result = char.TryParse("A", out char charValue);
Console.WriteLine($"Result: {result}, Char: {charValue}");
result = BigInteger.TryParse("18", NumberStyles.Integer, CultureInfo.InvariantCulture, out System.Numerics.BigInteger bigIntegerValue);
Console.WriteLine($"Result: {result}, BigInteger: {bigIntegerValue}");
result = nint.TryParse("18", NumberStyles.Integer, CultureInfo.InvariantCulture, out nint nintValue);
Console.WriteLine($"Result: {result}, nint: {nintValue}");
result = nuint.TryParse("18", NumberStyles.Integer, CultureInfo.InvariantCulture, out nuint nuintValue);
Console.WriteLine($"Result: {result}, nuint: {nuintValue}");
result = DateTime.TryParse("2026-06-15 13:14:15", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime dateTimeValue);
Console.WriteLine($"Result: {result}, DateTime: {dateTimeValue}");

// Failure

result = int.TryParse("eighteen", NumberStyles.Integer, CultureInfo.InvariantCulture, out int invalidIntValue);
Console.WriteLine($"Result: {result}, Invalid Int: {invalidIntValue}");