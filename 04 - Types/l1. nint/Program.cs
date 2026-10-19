// European Union Public License version 1.2
// Copyright © 2026 Rick Beerendonk

Console.WriteLine(nint.MinValue); // -9223372036854775808
Console.WriteLine(nint.MaxValue); // 9223372036854775807

// Only Explicit initialization is allowed for nint
nint explicitValue = 2_147_483_647;  // _ for readability

Console.WriteLine(explicitValue.GetType().FullName); // System.IntPtr

// Size
// error CS0233: 'nint' does not have a predefined size, therefore sizeof can only be used in an unsafe context
//Console.WriteLine(sizeof(nint)); // 4 on 32-bit, 8 on 64-bit
Console.WriteLine($"Native integer width: {IntPtr.Size} bytes");