// European Union Public License version 1.2
// Copyright © 2025 Rick Beerendonk

// Get and Set accessors

Person person = new();

// Set property
person.Name = "Rick";
person.Age = 30;

// Get property
Console.WriteLine($"Name: {person.Name}");
Console.WriteLine($"Age: {person.Age}");

// Try to set invalid age
person.Age = -5;
Console.WriteLine($"Age after invalid set: {person.Age}");

class Person
{
  private string _name = "";
  private int _age;

  public string Name
  {
    get { return _name; }
    set { _name = value; }
  }

  public int Age
  {
    get { return _age; }
    set
    {
      if (value >= 0)
      {
        _age = value;
      }
      else
      {
        Console.WriteLine("Age cannot be negative");
      }
    }
  }
}
