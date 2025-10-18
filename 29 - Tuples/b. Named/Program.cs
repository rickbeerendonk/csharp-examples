// European Union Public License version 1.2
// Copyright © 2025 Rick Beerendonk

// Named tuples

var person = (Name: "Alexandra", Age: 34, City: "Amsterdam");
Console.WriteLine($"Name: {person.Name}"); // Name: Alexandra
Console.WriteLine($"Age: {person.Age}"); // Age: 34
Console.WriteLine($"City: {person.City}"); // City: Amsterdam

// Function returning named tuple
var result = GetPersonInfo();
Console.WriteLine($"Info: {result.Name}, {result.Age} years old"); // Info: Bob, 25 years old

(string Name, int Age) GetPersonInfo()
{
  return ("Bob", 25);
}
