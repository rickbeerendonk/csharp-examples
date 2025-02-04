// European Union Public License version 1.2
// Copyright © 2024 Rick Beerendonk

Test test1 = new Test("C#");
//test1.Name = "Visual Basic";  // Error CS8852  Init-only property or indexer 'Test.Name' can only be assigned in an object initializer, or on 'this' or 'base' in an instance constructor or an 'init' accessor.
Console.WriteLine(test1.Name);

Test test2 = new Test
{
    Name = "CSharp"
};
//test2.Name = "C++"; // Error CS8852  Init-only property or indexer 'Test.Name' can only be assigned in an object initializer, or on 'this' or 'base' in an instance constructor or an 'init' accessor.
Console.WriteLine(test2.Name);

public class Test
{
    // C# 9 (and up)
    // Init Only Setters
    // https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/proposals/csharp-9.0/init
    public string Name { get; init; }

    public Test()
    {}

    public Test(string name)
    {
        this.Name = name;
    }
}
