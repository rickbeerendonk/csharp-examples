// European Union Public License version 1.2
// Copyright © 2025 Rick Beerendonk

// Unsubscribing from events

Button button = new("Submit");

void Handler1(object? sender, ButtonClickedEventArgs e) =>
  Console.WriteLine(
    $"Handler 1: '{e.ButtonName}' clicked at {e.ClickTime:yyyy-MM-dd HH:mm:ss}");
void Handler2(object? sender, ButtonClickedEventArgs e) =>
  Console.WriteLine(
    $"Handler 2: '{e.ButtonName}' clicked at {e.ClickTime:yyyy-MM-dd HH:mm:ss}");

// Subscribe
button.Clicked += Handler1;
button.Clicked += Handler2;

Console.WriteLine("First click:");
button.Click();

// Unsubscribe Handler1
button.Clicked -= Handler1;

Console.WriteLine("\nSecond click (Handler1 removed):");
button.Click();

class Button(string name)
{
  public string Name { get; } = name;

  public event EventHandler<ButtonClickedEventArgs>? Clicked;

  public void Click()
  {
    Console.WriteLine($"Clicking '{Name}' button...");
    Clicked?.Invoke(this, new ButtonClickedEventArgs(Name, DateTime.Now));
  }
}

class ButtonClickedEventArgs(string buttonName, DateTime clickTime) : EventArgs
{
  public string ButtonName { get; } = buttonName;
  public DateTime ClickTime { get; } = clickTime;
}
