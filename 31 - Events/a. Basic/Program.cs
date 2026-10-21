// European Union Public License version 1.2
// Copyright © 2025 Rick Beerendonk

// Basic event declaration and usage

Button button = new("Submit");

// Subscribe to event
button.Clicked += () => Console.WriteLine($"Button '{button.Name}' clicked!");

// Trigger event
button.Click();

class Button(string name)
{
  public string Name { get; } = name;

  // Event declaration
  public event Action? Clicked;

  public void Click()
  {
    Console.WriteLine($"Clicking '{Name}' button...");
    Clicked?.Invoke();
  }
}
