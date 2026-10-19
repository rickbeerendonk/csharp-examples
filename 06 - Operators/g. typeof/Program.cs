// European Union Public License version 1.2
// Copyright © 2025 Rick Beerendonk

// typeof operator gets the System.Type instance for a type
Type intType = typeof(int);
Console.WriteLine($"Type of int: {intType}"); // System.Int32
Console.WriteLine($"Full name: {intType.FullName}"); // System.Int32

Type stringType = typeof(string);
Console.WriteLine($"Type of string: {stringType}"); // System.String

Type myClassType = typeof(MyClass);
Console.WriteLine($"Type of MyClass: {myClassType}"); // Namespace.MyClass

class MyClass { }
