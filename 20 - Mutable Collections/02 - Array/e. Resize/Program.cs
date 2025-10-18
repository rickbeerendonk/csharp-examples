// European Union Public License version 1.2
// Copyright © 2025 Rick Beerendonk

// Arrays have fixed size, use Array.Resize to change size
int[] arr = [1, 2, 3];

Console.WriteLine($"Original length: {arr.Length}");

Array.Resize(ref arr, 5);
arr[3] = 4;
arr[4] = 5;

foreach (int item in arr)
{
  Console.WriteLine(item);
}

Console.WriteLine($"New length: {arr.Length}");

// Original length: 3
// 1
// 2
// 3
// 4
// 5
// New length: 5
