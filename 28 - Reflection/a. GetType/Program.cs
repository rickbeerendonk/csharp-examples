// European Union Public License version 1.2
// Copyright © 2026 Rick Beerendonk

// Basic reflection - getting type information

using ReflectionExamples;

Person person = new("Anouk", 30);

Type type = person.GetType();
Console.WriteLine($"Type name: {type.Name}");
Console.WriteLine($"Full name: {type.FullName}");
Console.WriteLine($"Namespace: {type.Namespace}");
Console.WriteLine($"Is class: {type.IsClass}");
Console.WriteLine($"Is value type: {type.IsValueType}");

// Type name: Person
// Full name: ReflectionExamples.Person
// Namespace: ReflectionExamples
// Is class: True
// Is value type: False

namespace ReflectionExamples
{
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
}
