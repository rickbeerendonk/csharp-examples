// European Union Public License version 1.2
// Copyright © 2023 Rick Beerendonk

var demo1 = new Demo("one");
Console.WriteLine(demo1.Name);
Console.WriteLine(demo1.Age);
// Constructor (name, age) done
// Constructor (name) done
// one
// 50

var demo2 = new Demo("two", 20);
Console.WriteLine(demo2.Name);
Console.WriteLine(demo2.Age);
// Constructor (name, age) done
// two
// 20



class Demo {
  // Constructor 1 calling Constructor 2
  public Demo(string name) : this(name, 50) {
    Console.WriteLine("Constructor (name) done");
  }

  // Constructor 2
  public Demo(string name, int age) {
    Age = age;
    Name = name;
    Console.WriteLine("Constructor (name, age) done");
  }

  public int Age { get; }
  public string Name { get; }
}
