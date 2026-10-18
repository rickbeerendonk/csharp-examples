// European Union Public License version 1.2
// Copyright © 2025 Rick Beerendonk

// break exits the nearest loop or switch

int stopAt = 3;

// For

Console.WriteLine("for:");
for (int i = 1; i <= 5; i++)
{
  if (i == stopAt)
    break; // Exit the loop before printing 3.
  Console.WriteLine(i);
}

// Foreach

Console.WriteLine("foreach:");
foreach (int number in new[] { 1, 2, 3, 4, 5 })
{
  if (number == stopAt)
    break; // Exit the loop before printing 3.
  Console.WriteLine(number);
}

// While

Console.WriteLine("while:");
int count = 1;
while (count <= 5)
{
  if (count == stopAt)
    break; // Exit the loop before printing 3.
  Console.WriteLine(count++);
}

// Do-While

Console.WriteLine("do-while:");
count = 1;
do
{
  if (count == stopAt)
    break; // Exit the loop before printing 3.
  Console.WriteLine(count++);
} while (count <= 5);

// Switch

Console.WriteLine("switch:");
switch (stopAt)
{
  case 3:
    Console.WriteLine("Three");
    break; // Exit the switch section.
  default:
    Console.WriteLine("Other");
    break; // Exit the switch section.
}
