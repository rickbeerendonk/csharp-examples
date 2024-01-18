// European Union Public License version 1.2
// Copyright © 2024 Rick Beerendonk

IList<int> numbers = new List<int> { 1, 3, 5, 7, 9 };

Console.WriteLine(numbers.Contains(7));  // True

numbers[3] = 6;

Console.WriteLine(numbers.Contains(7));  // False