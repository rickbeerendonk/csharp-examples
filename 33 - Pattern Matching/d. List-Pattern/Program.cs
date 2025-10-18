// European Union Public License version 1.2
// Copyright © 2025 Rick Beerendonk

// List patterns (C# 11+)

int[] numbers = { 1, 2, 3, 4, 5 };

string description = numbers switch
{
  [] => "Empty array",
  [1] => "Array with single element: 1",
  [1, 2] => "Array with two elements: 1, 2",
  [1, 2, 3, ..] => "Array starting with 1, 2, 3",
  [.., 5] => "Array ending with 5",
  [var first, .., var last] => $"Array from {first} to {last}",
  _ => "Other array"
};

Console.WriteLine(description);

// Another example
int[] arr = { 10, 20 };
string result = arr switch
{
  [10, 20] => "Ten and Twenty",
  [_, _] => "Two elements",
  _ => "Other"
};

Console.WriteLine(result);
