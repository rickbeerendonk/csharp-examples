// European Union Public License version 1.2
// Copyright © 2025 Rick Beerendonk

// Generic constraints

// where T : struct (value type)
ValueContainer<int> intContainer = new(42);
Console.WriteLine($"Int value: {intContainer.Value}");

// where T : class (reference type)
ReferenceContainer<string> stringContainer = new("Hello");
Console.WriteLine($"String value: {stringContainer.Value}");

// where T : new() (must have parameterless constructor)
FactoryContainer<Person> personContainer = new();
Console.WriteLine($"Created: {personContainer.CreateInstance().Name}");

class ValueContainer<T> where T : struct
{
  public T Value { get; set; }

  public ValueContainer(T value)
  {
    Value = value;
  }
}

class ReferenceContainer<T> where T : class
{
  public T Value { get; set; }

  public ReferenceContainer(T value)
  {
    Value = value;
  }
}

class FactoryContainer<T> where T : new()
{
  public T CreateInstance()
  {
    return new T();
  }
}

class Person
{
  public string Name { get; set; } = "New Person";
}
