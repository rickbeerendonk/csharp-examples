// European Union Public License version 1.2
// Copyright © 2025 Rick Beerendonk

// Tuple equality

var tuple1 = (1, "Hello");
var tuple2 = (1, "Hello");
var tuple3 = (2, "World");

Console.WriteLine($"tuple1 == tuple2: {tuple1 == tuple2}"); // True
Console.WriteLine($"tuple1 == tuple3: {tuple1 == tuple3}"); // False
Console.WriteLine($"tuple1 != tuple3: {tuple1 != tuple3}"); // True

// Named tuples equality (names don't matter for equality)
var person1 = (Name: "Rick", Age: 30);
var person2 = (FirstName: "Rick", Years: 30);
Console.WriteLine($"person1 == person2: {person1 == person2}"); // True
