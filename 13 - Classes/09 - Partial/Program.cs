// European Union Public License version 1.2
// Copyright © 2025 Rick Beerendonk

// Partial classes allow a class definition to be split across multiple files

PartialPerson person = new();
person.FirstName = "Rick";
person.LastName = "Beerendonk";
person.Age = 30;

person.PrintName();
person.PrintAge();

// First part of the partial class
partial class PartialPerson
{
  public string FirstName { get; set; } = "";
  public string LastName { get; set; } = "";

  public void PrintName()
  {
    Console.WriteLine($"Name: {FirstName} {LastName}");
  }
}

// Second part of the partial class
partial class PartialPerson
{
  public int Age { get; set; }

  public void PrintAge()
  {
    Console.WriteLine($"Age: {Age}");
  }
}
