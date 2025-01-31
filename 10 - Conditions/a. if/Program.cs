// European Union Public License version 1.2
// Copyright © 2025 Rick Beerendonk

var moment = DateTime.Now;
var hour = moment.Hour;

// One line
if (hour < 6 || hour >= 18)
    Console.WriteLine("Good night");

// Block
if (hour >= 6 && hour < 18)
{
    Console.WriteLine("Good day");
}
