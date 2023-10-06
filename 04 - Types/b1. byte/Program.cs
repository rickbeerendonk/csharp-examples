// European Union Public License version 1.2
// Copyright © 2023 Rick Beerendonk

Console.WriteLine(byte.MinValue); // 0
Console.WriteLine(byte.MaxValue); // 255

// Explicit vs Implicit
byte explicitValue = 255;
var implicitValue = 255; // int

Console.WriteLine(explicitValue.GetType().FullName); // System.Byte
Console.WriteLine(implicitValue.GetType().FullName); // System.Int32