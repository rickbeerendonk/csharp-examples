// European Union Public License version 1.2
// Copyright © 2025 Rick Beerendonk

// Multiple event subscribers

Button button = new();

// Subscribe multiple handlers
button.Clicked += () => Console.WriteLine("First handler");
button.Clicked += () => Console.WriteLine("Second handler");
button.Clicked += () => Console.WriteLine("Third handler");

// Trigger event - all handlers execute
button.Click();

class Button
{
  public event Action? Clicked;

  public void Click()
  {
    Console.WriteLine("Button clicked");
    Clicked?.Invoke();
  }
}
