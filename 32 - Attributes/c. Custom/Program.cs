// European Union Public License version 1.2
// Copyright © 2025 Rick Beerendonk

// Custom attribute

MyClass obj = new();
obj.MyMethod();

// Read attributes using reflection
var classAttributes = typeof(MyClass).GetCustomAttributes(false);
foreach (var attr in classAttributes)
{
  Console.WriteLine($"Class attribute: {attr}");
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
class AuthorAttribute : Attribute
{
  public string Name { get; }

  public AuthorAttribute(string name)
  {
    Name = name;
  }

  public override string ToString() => $"Author: {Name}";
}

[AttributeUsage(AttributeTargets.Class)]
class VersionAttribute : Attribute
{
  public string Version { get; }

  public VersionAttribute(string version)
  {
    Version = version;
  }

  public override string ToString() => $"Version: {Version}";
}
