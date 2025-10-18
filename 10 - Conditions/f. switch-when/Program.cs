// European Union Public License version 1.2
// Copyright © 2025 Rick Beerendonk

// Switch with when clauses for additional conditions

int number = 15;

string result = number switch
{
  < 0 => "Negative",
  0 => "Zero",
  > 0 and <= 10 => "Between 1 and 10",
  > 10 and <= 20 when number % 5 == 0 => "Between 11 and 20, divisible by 5",
  > 10 and <= 20 => "Between 11 and 20",
  _ => "Greater than 20"
};

Console.WriteLine($"Number {number} is: {result}");
