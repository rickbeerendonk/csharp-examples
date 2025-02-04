// European Union Public License version 1.2
// Copyright © 2023 Rick Beerendonk

var demo = new Demo("one");

Console.WriteLine(demo.Name);

// Constructor done
// one


class Demo {
  public Demo(string name) {
    Name = name;
    Console.WriteLine("Constructor done");
  }

  public string Name { get; }
}
