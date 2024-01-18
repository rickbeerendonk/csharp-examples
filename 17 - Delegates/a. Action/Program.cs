// European Union Public License version 1.2
// Copyright © 2024 Rick Beerendonk

// Action
// Action<in>
// Action<in1, in2>

Action<string> bar = Foo.Bar;
bar("abc");  // Foo.Bar("abc")

class Foo
{
    public static void Bar(string value)
        => Console.WriteLine($"Foo.Bar({value})");
}