// European Union Public License version 1.2
// Copyright © 2024 Rick Beerendonk

List<List<string>> citiesPerCountry = [
    ["Amsterdam", "Rotterdam"],
    ["Oslo", "Bergen"],
    ["Copenhagen", "Aarhus"]
];

var cities = citiesPerCountry.SelectMany(c => c);

foreach (var city in cities)
{
    Console.WriteLine(city);
}

// Amsterdam
// Rotterdam
// Oslo
// Bergen
// Copenhagen
// Aarhus
