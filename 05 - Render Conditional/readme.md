# Render Conditional

Rendering conditionally is done with [Razor syntax](https://docs.microsoft.com/en-us/aspnet/core/mvc/views/razor?view=aspnetcore-5.0#conditionals-if-else-if-else-and-switch).

## If

```cshtml
<ul>
  @if (value)
  {
    <li>Rendered</li>
  }
  @if (!value)
  {
    <li>Not Rendered</li>
  }
</ul>
```

## Else

```cshtml
<ul>
  @if (value)
  {
    <li>Rendered</li>
  }
  else
  {
    <li>Not Rendered</li>
  }
</ul>
```

## Switch

```cshtml
@switch (number)
{
case 0:
  <p>Zero</p>
  break;
case 1:
  <p>One</p>
  break;
default:
  <p>Large number</p>
  break;
}
```

## Licence

European Union Public Licence version 1.2

## Copyright

Copyright © 2020 Rick Beerendonk
