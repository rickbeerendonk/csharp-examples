// European Union Public License version 1.2
// Copyright © 2025 Rick Beerendonk

// Reflecting on properties

using System.Reflection;

Person person = new("Anouk", 30);
Type type = typeof(Person);

PropertyInfo[] properties = type.GetProperties();
Console.WriteLine($"Properties of {type.Name}:");

foreach (var prop in properties)
{
  Console.WriteLine($"  {prop.Name} ({prop.PropertyType.Name})");
  object? value = prop.GetValue(person);
  Console.WriteLine($"    Value: {value}");
}

// Properties of Person:
//   Name (String)
//     Value: Anouk
//   Age (Int32)
//     Value: 30

class Person
{
  public string Name { get; set; }
  public int Age { get; set; }

  public Person(string name, int age)
  {
    Name = name;
    Age = age;
  }
}
