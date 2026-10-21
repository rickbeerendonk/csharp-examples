// European Union Public License version 1.2
// Copyright © 2025 Rick Beerendonk

// EventHandler pattern

Button button = new("Submit");

// Subscribe to event
button.Clicked += Button_Clicked;

// Trigger event
button.Click();

void Button_Clicked(object? sender, EventArgs e)
{
  Console.WriteLine($"Button '{button.Name}' clicked! Sender: {sender?.GetType().Name}");
}

class Button(string name)
{
  public string Name { get; } = name;

  // Event using EventHandler
  public event EventHandler? Clicked;

  public void Click()
  {
    Console.WriteLine($"Clicking '{Name}' button...");
    Clicked?.Invoke(this, EventArgs.Empty);
  }
}
