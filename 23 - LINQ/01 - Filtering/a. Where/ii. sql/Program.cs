// European Union Public License version 1.2
// Copyright © 2024 Rick Beerendonk

IEnumerable<int> numbers = [1, 2, 3, 4, 5];

var evenNumbers = 
    from n in numbers 
    where n % 2 == 0 
    select n;

foreach (var number in evenNumbers)
{
    Console.WriteLine(number);
}

// 2
// 4
