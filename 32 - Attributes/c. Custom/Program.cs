// European Union Public License version 1.2
// Copyright © 2026 Rick Beerendonk

// Custom attribute

MyClass obj = new();
obj.MyMethod();

// Read class attributes using reflection
var classAttributes = typeof(MyClass).GetCustomAttributes(false);
foreach (var attr in classAttributes)
{
  Console.WriteLine($"Class attribute: {attr}");
}

// Read method attributes using reflection
var method = typeof(MyClass).GetMethod(nameof(MyClass.MyMethod))
  ?? throw new InvalidOperationException("MyMethod was not found.");
var methodAttributes = method.GetCustomAttributes(false);
foreach (var attr in methodAttributes)
{
  Console.WriteLine($"Method attribute: {attr}");
}

[Author("Rick Beerendonk")]
[Version("1.0")]
class MyClass
{
  [Author("Rick")]
  public void MyMethod()
  {
    Console.WriteLine("Method with custom attribute");
  }
}

// Custom attribute definition
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
class AuthorAttribute(string name) : Attribute
{
  public string Name { get; } = name;

  public override string ToString() => $"Author: {Name}";
}

[AttributeUsage(AttributeTargets.Class)]
class VersionAttribute(string version) : Attribute
{
  public string Version { get; } = version;

  public override string ToString() => $"Version: {Version}";
}
