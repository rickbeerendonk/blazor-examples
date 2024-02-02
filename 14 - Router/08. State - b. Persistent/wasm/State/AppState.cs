/*! European Union Public License version 1.2 !*/
/*! Copyright © 2024 Rick Beerendonk          !*/

namespace Router_State_Persistent;

public class AppState
{
    private int _countHome = 0;
    private int _count1 = 0;
    private int _count2 = 0;

    public int CountHome
    {
        get => _countHome;
        set { _countHome = value; NotifyStateChanged(); }
    }

    public int Count1
    {
        get => _count1;
        set { _count1 = value; NotifyStateChanged(); }
    }

    public int Count2
    {
        get => _count2;
        set { _count2 = value; NotifyStateChanged(); }
    }

    public event Action? OnChange;

    private void NotifyStateChanged() => OnChange?.Invoke();
}
