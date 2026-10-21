// European Union Public License version 1.2
// Copyright © 2023 Rick Beerendonk

bool boolean = true;
int number = 123;
string text = "abc";

// Single line
// To use single-line string interpolation, prefix the string with $

Console.WriteLine($"bool: {boolean}, number+1: {number + 1}, text: {text} (length: {text.Length}), slash: \\, double quotes: \"");
// bool: True, number+1: 124, text: abc (length: 3), slash: \, double quotes: "

// Multi line
// To use multi-line string interpolation, combine $ and @ symbols as $@

Console.WriteLine($@"
bool: {boolean}
number+1: {number + 1}
text: {text} (length: {text.Length})
slash: \
double quotes: ""
");
// bool: True
// number+1: 124
// text: abc (length: 3)
// slash: \
// double quotes: "
