// European Union Public License version 1.2
// Copyright © 2025 Rick Beerendonk

// using statement
// Calls file1.Dispose() automatically at the end of the using block
using (var file1 = new StreamWriter("Using1.tmp"))
{
  file1.WriteLine("Hello, World!");
  file1.WriteLine("This is a test file.");
} // file1.Dispose() is called automatically

Console.WriteLine("File written and closed");

// using declaration (C# 8.0+)
// Calls file2.Dispose() at the end of the scope
using var file2 = new StreamWriter("Using2.tmp");
file2.WriteLine("Another test file");
// file2.Dispose() is called at the end of the scope

Console.WriteLine("Second file written");
