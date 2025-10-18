// European Union Public License version 1.2
// Copyright © 2025 Rick Beerendonk

// Named tuples

var person = (Name: "Rick", Age: 30, City: "Amsterdam");
Console.WriteLine($"Name: {person.Name}");
Console.WriteLine($"Age: {person.Age}");
Console.WriteLine($"City: {person.City}");

// Function returning named tuple
var result = GetPersonInfo();
Console.WriteLine($"Info: {result.Name}, {result.Age} years old");

(string Name, int Age) GetPersonInfo()
{
  return ("Alice", 25);
}
