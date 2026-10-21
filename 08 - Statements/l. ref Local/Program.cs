// European Union Public License version 1.2
// Copyright © 2025 Rick Beerendonk

// Benefit of using ref locals is that you can create an alias to an existing variable, 
// allowing you to modify it directly through the alias.

int x = 1;
ref int refX = ref x;

Console.WriteLine($"x: {x}");        // 1
Console.WriteLine($"refX: {refX}");  // 1

// Assignment through the alias updates x.
x = 2;
Console.WriteLine("\nAfter modifying x:");
Console.WriteLine($"x: {x}");        // 2
Console.WriteLine($"refX: {refX}");  // 2

// Assignment through the alias updates x.
refX = 3;
Console.WriteLine("\nAfter modifying refX:");
Console.WriteLine($"x: {x}");        // 3
Console.WriteLine($"refX: {refX}");  // 3

// An array element can also be aliased.
int[] numbers = [1, 2, 3, 4, 5];
ref int element = ref numbers[2];
Console.WriteLine($"\nAliased element: {element}");  // 3

element = 33;
Console.WriteLine($"After modifying: {string.Join(", ", numbers)}");  // 1, 2, 33, 4, 5

// A ref local can be redirected to a different array element.
element = ref numbers[^1];
element = 55;
Console.WriteLine($"After redirecting the alias: {string.Join(", ", numbers)}");  // 1, 2, 33, 4, 55
