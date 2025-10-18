// European Union Public License version 1.2
// Copyright © 2025 Rick Beerendonk

// using statement ensures IDisposable objects are disposed properly

using (var file = new StreamWriter("test.txt"))
{
  file.WriteLine("Hello, World!");
  file.WriteLine("This is a test file.");
} // file.Dispose() is called automatically

Console.WriteLine("File written and closed");

// using declaration (C# 8.0+)
using var file2 = new StreamWriter("test2.txt");
file2.WriteLine("Another test file");
// file2.Dispose() is called at the end of the scope

Console.WriteLine("Second file written");
