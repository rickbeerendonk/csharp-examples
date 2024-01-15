// European Union Public License version 1.2
// Copyright © 2023 Rick Beerendonk

// C# 12

// Running shouldn't fail
var demo1 = new Demo1("one");
var demo2 = new Demo2("two");

Console.WriteLine(demo1.Name); // one
Console.WriteLine(demo2.Name); // two

// Short notation: Primary constructor
class Demo1(string name) {
  public string Name { get; } = name;
}

// Long notation: Non-Primary constructor
class Demo2 {
  public Demo2(string name) {
    Name = name;
  }

  public string Name { get; }
}
