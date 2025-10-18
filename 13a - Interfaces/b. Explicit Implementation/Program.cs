// European Union Public License version 1.2
// Copyright © 2025 Rick Beerendonk

// Explicit interface implementation

MyClass obj = new();
obj.DoSomething(); // Regular method

// Explicit interface implementation - must cast to interface
IInterface1 i1 = obj;
i1.DoSomething();

IInterface2 i2 = obj;
i2.DoSomething();

interface IInterface1
{
  void DoSomething();
}

interface IInterface2
{
  void DoSomething();
}

class MyClass : IInterface1, IInterface2
{
  public void DoSomething()
  {
    Console.WriteLine("Regular DoSomething");
  }

  // Explicit implementation for IInterface1
  void IInterface1.DoSomething()
  {
    Console.WriteLine("IInterface1.DoSomething");
  }

  // Explicit implementation for IInterface2
  void IInterface2.DoSomething()
  {
    Console.WriteLine("IInterface2.DoSomething");
  }
}
