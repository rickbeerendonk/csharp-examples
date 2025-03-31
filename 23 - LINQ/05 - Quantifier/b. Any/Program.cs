// European Union Public License version 1.2
// Copyright © 2025 Rick Beerendonk

List<int> numbers = [1, 3, 5, 7, 9];

// Any even number?
Console.WriteLine(numbers.Any(n => n % 2 == 0));  // False

numbers[3] = 6;

// Any even number?
Console.WriteLine(numbers.Any(n => n % 2 == 0));  // True