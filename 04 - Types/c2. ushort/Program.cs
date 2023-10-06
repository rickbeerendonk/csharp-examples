// European Union Public License version 1.2
// Copyright © 2023 Rick Beerendonk

Console.WriteLine(ushort.MinValue); // 0
Console.WriteLine(ushort.MaxValue); // 65535

// Explicit vs Implicit
ushort explicitValue = 65535;
var implicitValue = 65535; // int

Console.WriteLine(explicitValue.GetType().FullName); // System.UInt16
Console.WriteLine(implicitValue.GetType().FullName); // System.Int32