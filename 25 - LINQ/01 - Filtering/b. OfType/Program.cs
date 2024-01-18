// European Union Public License version 1.2
// Copyright © 2024 Rick Beerendonk

List<object> items = [1, "two", 3, true, 5];

var numbers = items.OfType<int>();

foreach (var number in numbers)
{
    Console.WriteLine(number);
}

// 1
// 3
// 5