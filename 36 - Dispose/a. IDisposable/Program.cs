// European Union Public License version 1.2
// Copyright © 2025 Rick Beerendonk

// IDisposable and using statement

using (var resource = new MyResource())
{
  resource.DoWork();
  Console.WriteLine("Inside using block");
}
Console.WriteLine("After using block - resource disposed");

// Using declaration (C# 8+)
using var resource2 = new MyResource();
resource2.DoWork();
Console.WriteLine("Resource will be disposed at end of scope");

class MyResource : IDisposable
{
  public void DoWork()
  {
    Console.WriteLine("Doing work...");
  }

  public void Dispose()
  {
    Console.WriteLine("Resource disposed");
  }
}

// Doing work...
// Inside using block
// Resource disposed
// After using block - resource disposed
// Doing work...
// Resource will be disposed at end of scope
// Resource disposed
