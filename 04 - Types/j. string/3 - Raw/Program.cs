// European Union Public License version 1.2
// Copyright © 2024 Rick Beerendonk

// Raw String
Console.WriteLine("""
  "Line1"\n"Line2"
  """);
// "Line1"\n"Line2"

// Raw String with Interpolation
Console.WriteLine($"""
  "Line{1}"\n"Line{1+1}"
  """);
// "Line1"\n"Line2"
