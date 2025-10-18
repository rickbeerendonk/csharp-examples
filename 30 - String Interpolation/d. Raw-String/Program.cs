// European Union Public License version 1.2
// Copyright © 2025 Rick Beerendonk

// Raw string literals (C# 11+)

string name = "Rick";

// Raw string literal with interpolation
string json = $$"""
{
  "name": "{{name}}",
  "age": 30,
  "city": "Amsterdam"
}
""";

Console.WriteLine(json);

// Multiple $ for nested braces
string multiDollar = $$$"""
  Normal: {{{name}}}
  """;
Console.WriteLine(multiDollar);
