// Copyright © 2026 Rick Beerendonk

using System.Globalization;

CultureInfo culture = CultureInfo.InvariantCulture;

bool flag = true;
Console.WriteLine(flag.ToString(culture));  // true
Console.WriteLine(Convert.ToString(flag, culture)); // true

byte number = 18;
Console.WriteLine(number.ToString(culture));  // 18
Console.WriteLine(Convert.ToString(number, culture)); // 18

short smallNumber = 18;
Console.WriteLine(smallNumber.ToString(culture));  // 18
Console.WriteLine(Convert.ToString(smallNumber, culture)); // 18

int integerNumber = 18;
Console.WriteLine(integerNumber.ToString(culture));  // 18
Console.WriteLine(Convert.ToString(integerNumber, culture)); // 18

long longNumber = 18;
Console.WriteLine(longNumber.ToString(culture));  // 18
Console.WriteLine(Convert.ToString(longNumber, culture)); // 18

decimal decimalNumber = 18.9m;
Console.WriteLine(decimalNumber.ToString(culture));  // 18.9
Console.WriteLine(Convert.ToString(decimalNumber, culture)); // 18.9

double doubleNumber = 18.9;
Console.WriteLine(doubleNumber.ToString(culture));  // 18.9
Console.WriteLine(Convert.ToString(doubleNumber, culture)); // 18.9

float floatNumber = 18.9f;
Console.WriteLine(floatNumber.ToString(culture));  // 18.9
Console.WriteLine(Convert.ToString(floatNumber, culture)); // 18.9

char character = 'A';
Console.WriteLine(character.ToString(culture));  // A
Console.WriteLine(Convert.ToString(character, culture)); // A

string text = "Hello";
Console.WriteLine(text.ToString(culture));  // Hello
Console.WriteLine(Convert.ToString(text, culture)); // Hello

DateTime date = new DateTime(2026, 6, 5, 13, 14, 15);
Console.WriteLine(date.ToString(culture));  // 05-06-2026 13:14:15
Console.WriteLine(Convert.ToString(date, culture)); // 05-06-2026 13:14:15

TimeSpan timeSpan = new TimeSpan(1, 2, 3);
Console.WriteLine(timeSpan.ToString());  // 01:02:03
Console.WriteLine(Convert.ToString(timeSpan, culture)); // 01:02:03

// Convert.ToString handles a null object by returning an empty string.
object? missing = null;
Console.WriteLine($"[{Convert.ToString(missing, culture)}]"); // []
