// European Union Public License version 1.2
// Copyright © 2025 Rick Beerendonk

// Dynamic type

dynamic value = 42;
Console.WriteLine($"Integer: {value}");

value = "Hello";
Console.WriteLine($"String: {value}");

value = new { Name = "Alice", Age = 30 };
Console.WriteLine($"Anonymous: Name={value.Name}, Age={value.Age}");

// Method calls resolved at runtime
dynamic list = new List<int> { 1, 2, 3 }; // Keep explicit type for dynamic demo
list.Add(4);
Console.WriteLine($"List count: {list.Count}");

// Integer: 42
// String: Hello
// Anonymous: Name=Alice, Age=30
// List count: 4
