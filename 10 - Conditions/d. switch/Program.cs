// European Union Public License version 1.2
// Copyright © 2025 Rick Beerendonk

var moment = DateTime.Now;
var hour = moment.Hour;
var dayOfWeek = moment.DayOfWeek;
var day = (int)moment.DayOfWeek;
var month = moment.Month;

// Enum
switch (dayOfWeek)
{
    case DayOfWeek.Monday:
        Console.WriteLine("Monday");
        break;
    case DayOfWeek.Tuesday:
        Console.WriteLine("Tuesday");
        break;
    case DayOfWeek.Wednesday:
        Console.WriteLine("Wednesday");
        break;
    case DayOfWeek.Thursday:
        Console.WriteLine("Thursday");
        break;
    case DayOfWeek.Friday:
        Console.WriteLine("Friday");
        Console.WriteLine("Almost weekend");
        break;
    default:
        Console.WriteLine("Weekend!");
        break;
}

// Int
switch (day)
{
    case 1:
        Console.WriteLine("Monday");
        break;
    case 2:
        Console.WriteLine("Tuesday");
        break;
    case 3:
        Console.WriteLine("Wednesday");
        break;
    case 4:
        Console.WriteLine("Thursday");
        break;
    case 5:
        Console.WriteLine("Friday");
        Console.WriteLine("Almost weekend");
        break;
    default:
        Console.WriteLine("Weekend!");
        break;
}

// Type & is
object x = "String";
switch (x)
{
    case int:
        Console.WriteLine("Number");
        break;
    case string:
        Console.WriteLine("Text");
        break;
    default:
        Console.WriteLine("No Text");
        break;
}

// Multiple cases
switch (month)
{
    case 1:
    case 2:
    case 3:
        Console.WriteLine("Winter");
        break;
    case (>= 4 and <= 6):
        Console.WriteLine("Spring");
        break;
    case (< 10):
        Console.WriteLine("Summer");
        break;
    default:
        Console.WriteLine("Autumn");
        break;
}