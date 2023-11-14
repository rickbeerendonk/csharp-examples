// European Union Public License version 1.2
// Copyright © 2023 Rick Beerendonk

// C# 12

// Running shouldn't fail
var demo1 = new Demo1("one");
var demo2 = new Demo2("two");

Console.WriteLine(demo1.Name); // one
Console.WriteLine(demo2.Name); // two


// Long notation
class Demo1 {
  public Demo1(string name) {
    Name = name;
  }

  public string Name { get; }
}

// Short notation
class Demo2(string name) {
  public string Name { get; } = name;
}
