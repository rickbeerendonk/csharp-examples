// European Union Public License version 1.2
// Copyright © 2025 Rick Beerendonk

// nameof operator returns the name of a variable, type, or member as a string
int count = 10;
Console.WriteLine($"Variable name: {nameof(count)}"); // Variable name: count

Console.WriteLine($"Type name: {nameof(MyClass)}"); // Type name: MyClass
Console.WriteLine($"Method name: {nameof(MyClass.MyMethod)}"); // Method name: MyMethod
Console.WriteLine($"Property name: {nameof(MyClass.MyProperty)}"); // Property name: MyProperty

class MyClass
{
  public string MyProperty { get; set; } = "";
  public void MyMethod() { }
}
