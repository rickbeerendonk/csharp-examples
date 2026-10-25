// European Union Public License version 1.2
// Copyright © 2025 Rick Beerendonk

// Reading from a file

string filePath = "readings.txt";

// Write content first
string[] readings = [
  "s-amsterdam-01: 18 °C",
  "s-oslo-01: 16 °C",
  "s-copenhagen-01: 19 °C"
];
File.WriteAllLines(filePath, readings);

// Read all text
string content = File.ReadAllText(filePath);
Console.WriteLine("File content:");
Console.WriteLine(content);

// Read all lines
string[] lines = File.ReadAllLines(filePath);
Console.WriteLine($"\nTotal lines: {lines.Length}");
foreach (var line in lines)
{
  Console.WriteLine($"Line: {line}");
}

// Clean up
File.Delete(filePath);

// File content:
// s-amsterdam-01: 18 °C
// s-oslo-01: 16 °C
// s-copenhagen-01: 19 °C
//
// Total lines: 3
// Line: s-amsterdam-01: 18 °C
// Line: s-oslo-01: 16 °C
// Line: s-copenhagen-01: 19 °C
