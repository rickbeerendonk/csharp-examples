// European Union Public License version 1.2
// Copyright © 2025 Rick Beerendonk

// Multiple event subscribers

Button button = new("Submit");

// Subscribe multiple handlers
button.Clicked += (_, e) =>
  Console.WriteLine(
    $"First handler: '{e.ButtonName}' clicked at {e.ClickTime:yyyy-MM-dd HH:mm:ss}");
button.Clicked += (_, e) =>
  Console.WriteLine(
    $"Second handler: '{e.ButtonName}' clicked at {e.ClickTime:yyyy-MM-dd HH:mm:ss}");
button.Clicked += (_, e) =>
  Console.WriteLine(
    $"Third handler: '{e.ButtonName}' clicked at {e.ClickTime:yyyy-MM-dd HH:mm:ss}");

// Trigger event - all handlers execute
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
