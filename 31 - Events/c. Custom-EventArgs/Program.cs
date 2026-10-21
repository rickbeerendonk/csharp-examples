// European Union Public License version 1.2
// Copyright © 2025 Rick Beerendonk

// Custom event with EventArgs

Button button = new("Submit");

// Subscribe to event
button.Clicked += Button_Clicked;

// Trigger event
button.Click();

void Button_Clicked(object? sender, ButtonClickedEventArgs e)
{
  Console.WriteLine(
    $"Button '{e.ButtonName}' clicked at {e.ClickTime:yyyy-MM-dd HH:mm:ss}");
}

class Button(string name)
{
  public string Name { get; } = name;

  // Custom event with custom EventArgs
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
