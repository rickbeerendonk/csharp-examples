// European Union Public License version 1.2
// Copyright © 2024 Rick Beerendonk

List<int> numbers1 = [1, 2, 3];
List<int> numbers2 = [4, 5];

var numbers = numbers1.Concat(numbers2);

foreach (var number in numbers)
{
    Console.WriteLine(number);
}

// 1
// 2
// 3
// 4
// 5
