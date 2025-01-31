// European Union Public License version 1.2
// Copyright © 2025 Rick Beerendonk

var moment = DateTime.Now;
var hour = moment.Hour;

if (hour < 6)
{
    Console.WriteLine("Good night");
}
else if (hour < 12)
{
    Console.WriteLine("Good morning");
}
else if (hour < 18)
{
    Console.WriteLine("Good afternoon");
}
else
{
    Console.WriteLine("Good evening");
}
