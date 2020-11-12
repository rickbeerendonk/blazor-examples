# Render List

Rendering lists is done with [Razor syntax](https://docs.microsoft.com/en-us/aspnet/core/mvc/views/razor?view=aspnetcore-5.0#looping-for-foreach-while-and-do-while).

## For

```cshtml
  @for (int i = 0; i < items.Length; i++)
  {
    <li>@items[i]</li>
  }
```

## For Each

```cshtml
<ul>
  @foreach (var item in items)
  {
    <li>@item</li>
  }
</ul>
```

## While

```cshtml
<ul>
  @{ int i = 0;}
  @while (i < items.Length)
  {
    <li>@items[i]</li>
    i++;
  }
</ul>
```

## Do While

```cshtml
<ul>
  @{ int i = 0;}
  @do
  {
    <li>@items[i]</li>
    i++;
  } while (i < items.Length);
</ul>
```

## Licence

European Union Public Licence version 1.2

## Copyright

Copyright © 2020 Rick Beerendonk
