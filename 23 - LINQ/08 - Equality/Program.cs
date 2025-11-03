// European Union Public License version 1.2
// Copyright © 2025 Rick Beerendonk

// Example 1: SequenceEqual with primitive types

List<int> numbers1 = [1, 2, 3, 4, 5];
List<int> numbers2 = [1, 2, 3, 4, 5];
List<int> numbers3 = [1, 2, 3, 5, 4];

Console.WriteLine($"numbers1.SequenceEqual(numbers2): {numbers1.SequenceEqual(numbers2)}"); // True
Console.WriteLine($"numbers1.SequenceEqual(numbers3): {numbers1.SequenceEqual(numbers3)}"); // False

// Example 2: SequenceEqual with reference types (records)

List<Person> people1 =
[
    new("Alice", 30),
    new("Bob", 25),
    new("Charlie", 40)
];
List<Person> people2 =
[
    new("Alice", 30),
    new("Bob", 25),
    new("Charlie", 40)
];
List<Person> people3 =
[
    new("Alice", 30),
    new("Charlie", 40),
    new("Bob", 25)
];

Console.WriteLine($"people1.SequenceEqual(people2): {people1.SequenceEqual(people2)}"); // True
Console.WriteLine($"people1.SequenceEqual(people3): {people1.SequenceEqual(people3)}"); // False (order matters)

// Example 3: SequenceEqual with custom equality comparer (case-insensitive)

string[] fruits1 = ["Apple", "Banana", "Cherry"];
string[] fruits2 = ["apple", "banana", "cherry"];
bool equalIgnoreCase = fruits1.SequenceEqual(fruits2, StringComparer.OrdinalIgnoreCase);
Console.WriteLine($"fruits1.SequenceEqual(fruits2, StringComparer.OrdinalIgnoreCase): {equalIgnoreCase}"); // True

public record Person(string Name, int Age);

