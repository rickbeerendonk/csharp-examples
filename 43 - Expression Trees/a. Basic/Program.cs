// European Union Public License version 1.2
// Copyright © 2025 Rick Beerendonk

// Expression trees - representing code as data

using System.Linq.Expressions;

// Lambda expression
Func<int, int, int> add = (a, b) => a + b;
Console.WriteLine($"Lambda result: {add(3, 4)}");

// Expression tree
Expression<Func<int, int, int>> addExpr = (a, b) => a + b;
Console.WriteLine($"\nExpression: {addExpr}");
Console.WriteLine($"Body: {addExpr.Body}");
Console.WriteLine($"Parameters: {string.Join(", ", addExpr.Parameters)}");

// Compile and execute
var compiled = addExpr.Compile();
Console.WriteLine($"Compiled result: {compiled(3, 4)}");

// Lambda result: 7
//
// Expression: (a, b) => (a + b)
// Body: (a + b)
// Parameters: a, b
// Compiled result: 7
