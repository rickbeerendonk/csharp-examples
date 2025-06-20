// European Union Public License version 1.2
// Copyright © 2025 Rick Beerendonk

var demo1 = new Demo<int>(1, 2);
var demo2 = new Demo<double>(3.0, 4.0);

Console.WriteLine($"one={demo1.One}, two={demo1.Two}");
Console.WriteLine(demo1.GetType().Name);
Console.WriteLine(demo1.One.GetType().Name);

Console.WriteLine($"one={demo2.One}, two={demo2.Two}");
Console.WriteLine(demo2.GetType().Name);
Console.WriteLine(demo2.One.GetType().Name);

class Demo<T>
{
    public T One { get; }
    public T Two { get; }

    public Demo(T one, T two)
    {
        One = one;
        Two = two;
    }
}
