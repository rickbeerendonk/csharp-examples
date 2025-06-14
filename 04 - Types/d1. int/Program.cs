// European Union Public License version 1.2
// Copyright © 2023 Rick Beerendonk

Console.WriteLine(int.MinValue); // -2147483648
Console.WriteLine(int.MaxValue); // 2147483647

// Explicit vs Implicit
int explicitValue = 2_147_483_647;  // _ for readability
var implicitValue = 2_147_483_647;  // _ for readability

Console.WriteLine(explicitValue.GetType().FullName); // System.Int32
Console.WriteLine(implicitValue.GetType().FullName); // System.Int32

// Size
Console.WriteLine(sizeof(int)); // 4