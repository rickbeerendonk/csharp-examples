// European Union Public License version 1.2
// Copyright © 2025 Rick Beerendonk

// Basic event declaration and usage

Button button = new();

// Subscribe to event
button.Clicked += () => Console.WriteLine("Button was clicked!");

// Trigger event
button.Click();
button.Click();

class Button
{
  // Event declaration
  public event Action? Clicked;

  public void Click()
  {
    Console.WriteLine("Clicking button...");
    Clicked?.Invoke();
  }
}
