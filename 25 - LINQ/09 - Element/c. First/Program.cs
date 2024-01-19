// European Union Public License version 1.2
// Copyright © 2024 Rick Beerendonk

List<int> numbers = [1, 2, 3];

// Without filter
Console.WriteLine(numbers.First());  // 1

// With filter
Console.WriteLine(numbers.First(n => n % 2 == 0));  // 2

numbers.Clear();

// Empty collection
Console.WriteLine(numbers.First());  // InvalidOperationException