// European Union Public License version 1.2
// Copyright © 2024 Rick Beerendonk

IEnumerable<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

var reverseNumbers = numbers.Reverse();

foreach (var number in reverseNumbers)
{
    Console.WriteLine(number);
}

// 5
// 4
// 3
// 2
// 1