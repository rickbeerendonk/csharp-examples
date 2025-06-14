// European Union Public License version 1.2
// Copyright © 2023 Rick Beerendonk

Console.WriteLine(byte.MinValue); // 0
Console.WriteLine(byte.MaxValue); // 255

// Explicit vs Implicit
byte explicitValue = 255;
var implicitValue1 = 255; // int
var implicitValue2 = (byte)255;

Console.WriteLine(explicitValue.GetType().FullName);  // System.Byte
Console.WriteLine(implicitValue1.GetType().FullName); // System.Int32
Console.WriteLine(implicitValue2.GetType().FullName); // System.Byte

// Size
Console.WriteLine(sizeof(byte)); // 1
