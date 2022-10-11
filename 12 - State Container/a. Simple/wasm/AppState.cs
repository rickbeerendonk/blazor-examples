/*! European Union Public License version 1.2 !*/
/*! Copyright © 2021 Rick Beerendonk          !*/

namespace StateContainer_Simple;

public class AppState
{
    public string Color { get; private set; } = "red";

    public event Action? OnChange;

    public void SwitchColor()
    {
        Color = (Color == "red") ? "green" : "red";
        NotifyStateChanged();
    }

    private void NotifyStateChanged() => OnChange?.Invoke();
}
