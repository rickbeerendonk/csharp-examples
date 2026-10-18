// European Union Public License version 1.2
// Copyright © 2025 Rick Beerendonk

// Benefit of using ref locals is that you can create an alias to an existing variable, 
// allowing you to modify it directly through the alias.

int x = 1;
ref int refX = ref x;

Console.WriteLine($"x: {x}");
Console.WriteLine($"refX: {refX}");

// Assignment through the alias updates x.
x = 2;
Console.WriteLine("\nAfter modifying x:");
Console.WriteLine($"x: {x}");
Console.WriteLine($"refX: {refX}");

// Assignment through the alias updates x.
refX = 3;
Console.WriteLine("\nAfter modifying refX:");
Console.WriteLine($"x: {x}");
Console.WriteLine($"refX: {refX}");

// An array element can also be aliased.
int[] numbers = [1, 2, 3, 4, 5];
ref int middle = ref numbers[2];
Console.WriteLine($"\nMiddle element: {middle}");

middle = 33;
Console.WriteLine($"After modifying: {string.Join(", ", numbers)}");

// x: 1
// refX: 1
//
// After modifying x:
// x: 2
// refX: 2
//
// After modifying refX:
// x: 3
// refX: 3
//
// Middle element: 3
// After modifying: 1, 2, 33, 4, 5
