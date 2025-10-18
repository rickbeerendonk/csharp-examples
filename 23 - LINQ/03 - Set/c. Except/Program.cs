// European Union Public License version 1.2
// Copyright © 2025 Rick Beerendonk

IEnumerable<int> first = [1, 2, 3, 4, 5];
IEnumerable<int> second = [3, 4, 5, 6, 7];

var result = first.Except(second);

foreach (var number in result)
{
    Console.WriteLine(number);
}

// 1
// 2
