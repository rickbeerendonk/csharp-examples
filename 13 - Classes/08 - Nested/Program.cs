// European Union Public License version 1.2
// Copyright © 2025 Rick Beerendonk

// Nested classes are classes defined within another class

OuterClass outer = new();
outer.PrintMessage();

OuterClass.InnerClass inner = new();
inner.PrintInnerMessage();

class OuterClass
{
  private string _message = "From outer class";

  public void PrintMessage()
  {
    Console.WriteLine(_message);
  }

  // Nested class
  public class InnerClass
  {
    public void PrintInnerMessage()
    {
      Console.WriteLine("From inner class");
    }
  }

  // Private nested class
  private class PrivateInner
  {
    public void DoSomething()
    {
      Console.WriteLine("Private inner class");
    }
  }
}
