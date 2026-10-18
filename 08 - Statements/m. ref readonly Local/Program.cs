// European Union Public License version 1.2
// Copyright © 2025 Rick Beerendonk

// Variable

int x = 1;
ref readonly int refX = ref x;
Console.WriteLine($"x: {x}");
Console.WriteLine($"refX: {refX}");

// The alias observes changes made through the original variable.
x = 2;
Console.WriteLine($"\nAfter modifying x:");
Console.WriteLine($"x: {x}");
Console.WriteLine($"refX: {refX}");

// refX = 3; // Compile-time error: a ref readonly local cannot be assigned.

// Array element

int[] numbers = [1, 2, 3, 4, 5];

ref readonly int middle = ref numbers[2];
Console.WriteLine($"\nMiddle element: {middle}");

// Reassign the alias; the array elements remain unchanged.
middle = ref numbers[3];
Console.WriteLine($"Next element: {middle}");
Console.WriteLine($"Array: {string.Join(", ", numbers)}");

// A read-only reference avoids copying a large struct.

BigStruct big = new(1, 2, 3, 4, 5);
ref readonly BigStruct refBig = ref big;
Console.WriteLine($"\nBigStruct values: {refBig.A}, {refBig.B}, {refBig.C}");

// x: 1
// refX: 1
//
// After modifying x:
// x: 2
// refX: 2
//
// Middle element: 3
// Next element: 4
// Array: 1, 2, 3, 4, 5
//
// BigStruct values: 1, 2, 3

struct BigStruct
{
  public int A, B, C, D, E;

  public BigStruct(int a, int b, int c, int d, int e)
  {
    A = a;
    B = b;
    C = c;
    D = d;
    E = e;
  }
}
