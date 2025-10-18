// European Union Public License version 1.2
// Copyright © 2025 Rick Beerendonk

// Constant patterns

int number = 42;

string result = number switch
{
  0 => "Zero",
  1 => "One",
  42 => "The Answer",
  100 => "One Hundred",
  _ => "Other number"
};

Console.WriteLine(result);

// Constant pattern with string
string day = "Monday";
string message = day switch
{
  "Monday" => "Start of the week",
  "Friday" => "End of the week",
  "Saturday" or "Sunday" => "Weekend",
  _ => "Midweek"
};

Console.WriteLine(message);
