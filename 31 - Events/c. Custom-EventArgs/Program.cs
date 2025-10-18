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
  Console.WriteLine($"Button '{e.ButtonName}' clicked at {e.ClickTime}");
}

class Button
{
  public string Name { get; }

  public Button(string name)
  {
    Name = name;
  }

  // Custom event with custom EventArgs
  public event EventHandler<ButtonClickedEventArgs>? Clicked;

  public void Click()
  {
    Console.WriteLine("Clicking button...");
    Clicked?.Invoke(this, new ButtonClickedEventArgs(Name, DateTime.Now));
  }
}

class ButtonClickedEventArgs : EventArgs
{
  public string ButtonName { get; }
  public DateTime ClickTime { get; }

  public ButtonClickedEventArgs(string buttonName, DateTime clickTime)
  {
    ButtonName = buttonName;
    ClickTime = clickTime;
  }
}
