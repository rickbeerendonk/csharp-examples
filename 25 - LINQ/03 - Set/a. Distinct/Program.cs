// European Union Public License version 1.2
// Copyright © 2024 Rick Beerendonk

IEnumerable<int> numbers = [1, 3, 1, 4, 2, 3, 2, 4];

var distinctNumbers = numbers.Distinct();

foreach (var number in distinctNumbers)
{
    Console.WriteLine(number);
}

// 1
// 3
// 4
// 2
