// European Union Public License version 1.2
// Copyright © 2024 Rick Beerendonk

List<string> firstNames = ["Alex", "Ben", "Chris", "David"];
List<string> lastNames = ["Allen", "Berends", "Cole", "Davenport"];

var names = firstNames.Zip(lastNames);

foreach (var name in names)
{
    Console.WriteLine(name);
}

// (Alex, Allen)
// (Ben, Berends)
// (Chris, Cole)
// (David, Davenport)
