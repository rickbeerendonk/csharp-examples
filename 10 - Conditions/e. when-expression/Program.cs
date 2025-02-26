﻿// European Union Public License version 1.2
// Copyright © 2025 Rick Beerendonk

var moment = DateTime.Now;
var hour = moment.Hour;
var dayOfWeek = moment.DayOfWeek;
var day = (int)moment.DayOfWeek;
var month = moment.Month;

// === Enum ===

// else branch is mandatory when not all cases are covered
var result = dayOfWeek switch
{
    DayOfWeek.Saturday or DayOfWeek.Sunday => "Weekend 😏",
    _ => "No weekend 😀"
};
Console.WriteLine(result);

// else branch is still mandatory when "all cases" are covered
result = dayOfWeek switch
{
    DayOfWeek.Monday or
    DayOfWeek.Tuesday or
    DayOfWeek.Wednesday or
    DayOfWeek.Thursday or
    DayOfWeek.Friday => "No weekend 😀",
    DayOfWeek.Saturday or
    DayOfWeek.Sunday => "Weekend 😏",
    _ => throw new Exception("All cases should be covered, like (DayOfWeek)7")
};
Console.WriteLine(result);

// === Int ===

// else branch is mandatory when not all cases are covered
result = day switch
{
    >= 1 and <= 5 => "No weekend 😀",
    _ => "Weekend 😏"
};
Console.WriteLine(result);

// else branch is mandatory when not all cases are covered
result = day switch
{
    < 1 or > 5 => "Weekend 😏",
    _ => "No weekend 😀"
};
Console.WriteLine(result);

// === Type & is ===
object x = "string";
result = x switch
{
    int => "Number",
    string => "Text",
    _ => "No Number or Text",
};
Console.WriteLine(result);

// === Multiple cases & in ===
result = month switch
{
    1 or 2 or 3 => "Winter",
    >= 4 and <= 6 => "Spring",
    < 10 or > 12 => "Summer",
    _ => "Autumn"
};
Console.WriteLine(result);

// === when instead of if-then-else ===
result = hour switch
{
    < 6 => "Good night",
    < 12 => "Good morning",
    < 18 => "Good afternoon",
    _ => "Good evening"
};
Console.WriteLine(result);
