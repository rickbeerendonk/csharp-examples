// European Union Public License version 1.2
// Copyright © 2025 Rick Beerendonk

// Tuple deconstruction

var tuple = (Name: "Alexandra", Age: 34, City: "Amsterdam");

// Deconstruct into separate variables
var (name, age, city) = tuple;
Console.WriteLine($"Name: {name}");
Console.WriteLine($"Age: {age}");
Console.WriteLine($"City: {city}");

// Deconstruct with explicit types
(string personName, int personAge, string personCity) = tuple;
Console.WriteLine($"Person: {personName}, {personAge}, {personCity}");

// Discard unwanted values with _
var (n, _, c) = tuple;
Console.WriteLine($"Name: {n}, City: {c}");

// Name: Alexandra
// Age: 34
// City: Amsterdam
// Person: Alexandra, 34, Amsterdam
// Name: Alexandra, City: Amsterdam