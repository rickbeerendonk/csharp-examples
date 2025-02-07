// European Union Public License version 1.2
// Copyright © 2024 Rick Beerendonk

List<int> numbers = [1, 2, 3, 4, 5];

// Without filter
Console.WriteLine(numbers.FirstOrDefault());  // 1

// With filter
Console.WriteLine(numbers.FirstOrDefault(n => n % 2 == 0));  // 2

numbers = [];

// Empty collection
Console.WriteLine(numbers.FirstOrDefault());  // 0