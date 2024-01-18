// European Union Public License version 1.2
// Copyright © 2024 Rick Beerendonk

List<int> numbers = [1, 3, 5, 7, 9];

Console.WriteLine(numbers.All(n => n % 2 == 1));  // True

numbers[4] = 6;

Console.WriteLine(numbers.All(n => n % 2 == 1));  // False