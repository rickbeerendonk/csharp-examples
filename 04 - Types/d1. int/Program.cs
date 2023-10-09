// European Union Public License version 1.2
// Copyright © 2023 Rick Beerendonk

Console.WriteLine(int.MinValue); // -2147483648
Console.WriteLine(int.MaxValue); // 2147483647

// Explicit vs Implicit
int explicitValue = 2147483647;
var implicitValue = 2147483647;

Console.WriteLine(explicitValue.GetType().FullName); // System.Int32
Console.WriteLine(implicitValue.GetType().FullName); // System.Int32