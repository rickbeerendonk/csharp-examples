// European Union Public License version 1.2
// Copyright © 2025 Rick Beerendonk

// Relational patterns

int temperature = 25;

string description = temperature switch
{
  < 0 => "Freezing",
  >= 0 and < 10 => "Cold",
  >= 10 and < 20 => "Cool",
  >= 20 and < 30 => "Warm",
  >= 30 => "Hot"
};

Console.WriteLine($"Temperature {temperature}°C is {description}");

// Multiple relational patterns
int age = 35;
string category = age switch
{
  < 13 => "Child",
  >= 13 and < 20 => "Teenager",
  >= 20 and < 65 => "Adult",
  >= 65 => "Senior"
};

Console.WriteLine($"Age {age} is {category}");
