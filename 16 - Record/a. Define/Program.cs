// European Union Public License version 1.2
// Copyright © 2023 Rick Beerendonk

// Create
Demo demo1 = new Demo(1, "two");
Demo demo2 = new Demo(1, "two");

// Generated Properties
Console.WriteLine(demo1.one);                // 1
Console.WriteLine(demo1.two);                // two

// Supported methods (open):
Console.WriteLine(demo1.Equals(demo2));      // True
Console.WriteLine(demo1.GetHashCode());      // 456035898
Console.WriteLine(demo1.ToString());         // Demo { one = 1, two = two }

// Supported methods (destructuring):
var (one, two) = demo1;
Console.WriteLine(one);       // 1
Console.WriteLine(two);       // two

// Supported methods (nondestructive mutation):
Console.WriteLine(demo1 with { two = "new" });  // Demo { one = 1, two = new }

// Define
public record Demo(int one, string two);
