// European Union Public License version 1.2
// Copyright © 2024 Rick Beerendonk

// Func<out>
// Func<in, out>
// Func<in1, in2, out>

Func<string, int> bar = Foo.Bar;
Console.WriteLine(bar("abc"));  // 3

class Foo
{
    public static int Bar(string value)
        => value.Length;
}