// European Union Public License version 1.2
// Copyright © 2026 Rick Beerendonk

// Private inner classes can only be accessed within the outer class
OuterClass outer = new();
outer.PrintMessage();
outer.PrintPrivateMessage();

// Public inner classes can be accessed outside the outer class
OuterClass.InnerClass inner = new();
inner.PrintInnerMessage();

class OuterClass
{
  private string _message = "From outer class";

  public void PrintMessage()
  {
    Console.WriteLine(_message);
  }

  public void PrintPrivateMessage() => new PrivateInner().DoSomething();

  // Nested classes are classes defined within another class
  
  public class InnerClass
  {
    public void PrintInnerMessage() => Console.WriteLine("From inner class");
  }

  private class PrivateInner
  {
    public void DoSomething() => Console.WriteLine("Private inner class");
  }
}
