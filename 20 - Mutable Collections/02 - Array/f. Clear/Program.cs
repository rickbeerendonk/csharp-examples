// European Union Public License version 1.2
// Copyright © 2025 Rick Beerendonk

// Collection expression
int[] arr = [1, 2, 3, 4, 5];

Array.Clear(arr); // Sets all elements to default value (0 for int)

foreach (int item in arr)
{
  Console.WriteLine(item);
}

// 0
// 0
// 0
// 0
// 0
