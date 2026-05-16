// European Union Public License version 1.2
// Copyright © 2025 Rick Beerendonk

// Partial class definition - Part 1

partial class Person
{
  public string Name { get; set; }
  public int Age { get; set; }

  public Person(string name, int age)
  {
    Name = name;
    Age = age;
  }

  public void PrintInfo()
  {
    Console.WriteLine($"Name: {Name}, Age: {Age}");
  }
}
