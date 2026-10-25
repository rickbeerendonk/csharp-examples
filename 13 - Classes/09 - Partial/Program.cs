// European Union Public License version 1.2
// Copyright © 2026 Rick Beerendonk

// Partial classes combine definitions from multiple files.

PartialPerson person = new();
person.FirstName = "Anna";
person.LastName = "Adams";
person.Age = 30;

person.PrintName();
person.PrintAge();
person.PrintNameAndAge();

// PartialPerson.Details.cs contains the other part of this class.
partial class PartialPerson
{
  public string FirstName { get; set; } = "";
  public string LastName { get; set; } = "";

  public void PrintName() => Console.WriteLine($"Name: {FirstName} {LastName}");

  public void PrintNameAndAge() => Console.WriteLine($"Name: {FirstName} {LastName}, Age: {Age}");
}
