// European Union Public License version 1.2
// Copyright © 2025 Rick Beerendonk

// Verbatim interpolated strings

string path = @"C:\Users\Rick\Documents";
string name = "file.txt";

// Verbatim with interpolation
string fullPath = $@"C:\Users\{name}\Documents\{name}";
Console.WriteLine(fullPath);

// Multi-line verbatim interpolated string
string multiLine = $@"
Name: {name}
Path: {path}
Full: {fullPath}
";
Console.WriteLine(multiLine);
