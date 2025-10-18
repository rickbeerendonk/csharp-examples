// European Union Public License version 1.2
// Copyright © 2025 Rick Beerendonk

// Pattern matching with type patterns

object obj = "Hello";

string description = obj switch
{
  int i => $"Integer: {i}",
  string s => $"String: {s}",
  double d => $"Double: {d}",
  bool b => $"Boolean: {b}",
  null => "Null",
  _ => $"Unknown type: {obj.GetType()}"
};

Console.WriteLine(description);

// Another example
obj = 42;
description = obj switch
{
  int i => $"Integer: {i}",
  string s => $"String: {s}",
  _ => "Other"
};

Console.WriteLine(description);
