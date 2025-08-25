# Events

# @on{EVENT}

```cshtml
<button @onclick="HandleClick">This has been clicked @count times!</button>

@code {
    private int count = 0;

    private void HandleClick(MouseEventArgs e) {
        count++;
    }
}
```

## Licence

European Union Public Licence version 1.2

## Copyright

Copyright © 2020 Rick Beerendonk
