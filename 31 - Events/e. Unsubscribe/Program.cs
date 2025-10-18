// European Union Public License version 1.2
// Copyright © 2025 Rick Beerendonk

// Unsubscribing from events

Button button = new();

void Handler1() => Console.WriteLine("Handler 1");
void Handler2() => Console.WriteLine("Handler 2");

// Subscribe
button.Clicked += Handler1;
button.Clicked += Handler2;

Console.WriteLine("First click:");
button.Click();

// Unsubscribe Handler1
button.Clicked -= Handler1;

Console.WriteLine("\nSecond click (Handler1 removed):");
button.Click();

class Button
{
  public event Action? Clicked;

  public void Click()
  {
    Clicked?.Invoke();
  }
}
