// European Union Public License version 1.2
// Copyright © 2024 Rick Beerendonk

Func<string> a = () => "EcmaScript";

Func<int, int> b = (x) => x * x;
Func<int, int> c = x => x * x; // Omit ()
Func<int, int> d = x => 
{
    int y = x * x;
    return y;
}; // Add { ...; return ...; }

Func<int, int, int> e = (x, y) => x * y;

Console.WriteLine(a());     // EcmaScript
Console.WriteLine(b(2));    // 4
Console.WriteLine(c(3));    // 9
Console.WriteLine(d(4));    // 16
Console.WriteLine(e(5, 6)); // 30