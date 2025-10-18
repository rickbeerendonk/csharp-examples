// European Union Public License version 1.2
// Copyright © 2025 Rick Beerendonk

// EventHandler pattern

Button button = new();

// Subscribe to event
button.Clicked += Button_Clicked;

// Trigger event
button.Click();

void Button_Clicked(object? sender, EventArgs e)
{
  Console.WriteLine($"Button clicked! Sender: {sender?.GetType().Name}");
}

class Button
{
  // Event using EventHandler
  public event EventHandler? Clicked;

  public void Click()
  {
    Console.WriteLine("Clicking button...");
    Clicked?.Invoke(this, EventArgs.Empty);
  }
}
