// European Union Public License version 1.2
// Copyright © 2025 Rick Beerendonk

var demo = new Demo();

// Use extension method
Console.WriteLine(demo.Sum());  // 3

class Demo
{
    public int First { get; } = 1;
    public int Second { get; } = 2;
}


// Extension method
static class DemoExtensions
{
    public static int Sum(this Demo demo)
    {
        return demo.First + demo.Second;
    }
}
