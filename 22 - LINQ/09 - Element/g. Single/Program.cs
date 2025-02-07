// European Union Public License version 1.2
// Copyright © 2024 Rick Beerendonk

List<int> numbers = [123];

// Without filter
Console.WriteLine(numbers.Single());  // 123

numbers = [1, 2, 3];

// With filter
Console.WriteLine(numbers.Single(n => n % 2 == 0));  // 2

numbers = [];
// numbers = [1, 2]

// Empty collection
//   Throws when there is not exactly one element.
Console.WriteLine(numbers.Single());  // InvalidOperationException