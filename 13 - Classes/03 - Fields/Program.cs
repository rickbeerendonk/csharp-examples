// European Union Public License version 1.2
// Copyright © 2026 Rick Beerendonk

// Fields are variables declared in a class

Person person = new()
{
  Name = "Rick",
  Age = 30
};

// Public fields can be accessed directly
Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");

// Private fields cannot be accessed directly, but can be accessed through a public method
//Console.WriteLine($"ID: {person._id}"); // Compile error
Console.WriteLine($"ID: {person.GetId()}");

class Person
{
  // Public fields
  public string Name = "";
  public int Age;

  // Private field
  private string _id = "123";

  public string GetId() => _id;
}
