// European Union Public License version 1.2
// Copyright © 2025 Rick Beerendonk

// Fields are variables declared in a class

Person person = new();
person.Name = "Rick";
person.Age = 30;

Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");

class Person
{
  // Public fields
  public string Name = "";
  public int Age;

  // Private field
  private string _id = "123";

  public string GetId() => _id;
}
