// European Union Public License version 1.2
// Copyright © 2023 Rick Beerendonk

Console.WriteLine(nuint.MinValue); // 0
Console.WriteLine(nuint.MaxValue); // 18446744073709551615

// Only Explicit initialization is allowed for nuint
nuint explicitValue = 4_294_967_295;

Console.WriteLine(explicitValue.GetType().FullName); // System.UIntPtr

// Size
//Console.WriteLine(sizeof(nuint)); // 4 on 32-bit, 8 on 64-bit
Console.WriteLine($"Native integer width: {IntPtr.Size} bytes");