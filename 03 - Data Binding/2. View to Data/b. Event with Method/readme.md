# Events

# @on{EVENT}

```cshtml
<button @onclick="handleClick">This has been clicked @count times!</button>

@code {
    private int count = 0;

    private void handleClick(MouseEventArgs e) {
        count++;
    }
}
```

## Licence

European Union Public Licence version 1.2

## Copyright

Copyright © 2020 Rick Beerendonk
