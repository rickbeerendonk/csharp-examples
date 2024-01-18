// European Union Public License version 1.2
// Copyright © 2024 Rick Beerendonk

List<string> names = ["Alex Allen", "Ben Berends", "Chris Cole", "David Davenport"];

var firstNames = names.Select(n => n.Split(' ').First());

foreach (var firstName in firstNames)
{
    Console.WriteLine(firstName);
}

// Alex
// Ben
// Chris
// David