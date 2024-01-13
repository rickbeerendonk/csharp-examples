// European Union Public License version 1.2
// Copyright © 2024 Rick Beerendonk

var a = () => "EcmaScript";

var b = (int x) => x * x;
var d = (int x) => 
{
    int y = x * x;
    return y;
}; // Add { ...; return ...; }

var e = (int x, int y) => x * y;

Console.WriteLine(a());     // EcmaScript
Console.WriteLine(b(2));    // 4
Console.WriteLine(d(4));    // 16
Console.WriteLine(e(5, 6)); // 30