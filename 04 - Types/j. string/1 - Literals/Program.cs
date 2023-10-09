// European Union Public License version 1.2
// Copyright © 2023 Rick Beerendonk

// Single line
string str = "Text";
Console.WriteLine(str);                              // Text
Console.WriteLine(str.Length);                       // 4
Console.WriteLine(str.Substring(1, 2));              // ex
Console.WriteLine(str.GetType().FullName);           // System.String

// Multi line
string multi1 = @"
    one
    ""two""
";
Console.WriteLine(multi1);

string multi2 = @"
    one
    ""two""
".Trim();
Console.WriteLine(multi2);

// Get character
Console.WriteLine(str[0]);                     // T
Console.WriteLine(str[0].GetType().FullName);  // System.Char

// Special characters (single line)
Console.WriteLine("first \"line\" \nsecond line");
