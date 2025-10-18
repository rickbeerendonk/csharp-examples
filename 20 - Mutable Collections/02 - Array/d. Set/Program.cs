// European Union Public License version 1.2
// Copyright © 2025 Rick Beerendonk

// Collection expression
int[] arr = [1, 2, 3, 4];

arr[1] = 20; // Set value at index 1

foreach (int item in arr)
{
  Console.WriteLine(item);
}

// 1
// 20
// 3
// 4
