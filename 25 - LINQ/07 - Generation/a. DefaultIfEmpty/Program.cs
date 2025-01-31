// European Union Public License version 1.2
// Copyright © 2025 Rick Beerendonk

List<int> numbers = new();

foreach (int number in numbers)
{
    Console.WriteLine(number);
}

Console.WriteLine("---");
// ---

foreach (int number in numbers.DefaultIfEmpty())
{
    Console.WriteLine(number);
}

// 0

Console.WriteLine("---");
// ---

numbers.Add(1);
numbers.Add(2);

foreach (int number in numbers.DefaultIfEmpty())
{
    Console.WriteLine(number);
}

// 1
// 2

