// European Union Public License version 1.2
// Copyright © 2023 Rick Beerendonk

Console.WriteLine(ulong.MinValue); // 0
Console.WriteLine(ulong.MaxValue); // 18446744073709551615

// Explicit vs Implicit
ulong explicitValue = 18446744073709551615;
var implicitValue = 18446744073709551615;  // ulong

Console.WriteLine(explicitValue.GetType().FullName); // System.UInt64
Console.WriteLine(implicitValue.GetType().FullName); // System.UInt64