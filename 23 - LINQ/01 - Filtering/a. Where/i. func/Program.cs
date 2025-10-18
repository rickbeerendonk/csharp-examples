// European Union Public License version 1.2
// Copyright © 2024 Rick Beerendonk

IEnumerable<int> numbers = [1, 2, 3, 4, 5];

IQueryable<int> numbersQ = numbers.AsQueryable();

IEnumerable<int> numbersE = numbersQ.AsEnumerable();

var evenNumbers = numbersE.Where(n => n % 2 == 0);

foreach (var number in evenNumbers)
{
    Console.WriteLine(number);
}

// 2
// 4
