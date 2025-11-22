// European Union Public License version 1.2
// Copyright © 2025 Rick Beerendonk

// C# test file approach:
// - Traditional C# class with test methods
// - Uses RenderComponent<T>() to render components
// - Good for developers familiar with standard C# testing
// - Compare with GreetingTests.razor for Razor syntax approach

using Bunit;
using Xunit;
using Application;

public class GreetingCSharpTests : TestContext
{
    [Fact]
    public void CanFindByElementType()
    {
        var cut = RenderComponent<Greeting>(); // Greeting.razor

        // Query by element type
        var heading = cut.Find("h1");
        Assert.NotNull(heading);
    }

    [Fact]
    public void CanFindByClass()
    {
        var cut = RenderComponent<Greeting>();

        // Query by CSS class
        var element = cut.Find(".greeting");
        Assert.NotNull(element);
    }

    [Fact]
    public void CanFindByText()
    {
        var cut = RenderComponent<Greeting>();

        // Query by text content using :contains selector
        var element = cut.Find("h1:contains('Hello World!')");
        Assert.NotNull(element);
    }

    [Fact]
    public void CanFindById()
    {
        var cut = RenderComponent<Greeting>();

        // Query by ID
        var input = cut.Find("#editbox");
        Assert.NotNull(input);
    }

    [Fact]
    public void CanFindByAttribute()
    {
        var cut = RenderComponent<Greeting>();

        // Query by attribute selector
        var input = cut.Find("input[type='text']");
        Assert.NotNull(input);
    }

    [Fact]
    public void CanFindAll()
    {
        var cut = RenderComponent<Greeting>();

        // Query multiple elements
        var inputs = cut.FindAll("input");
        Assert.Single(inputs);
    }

    [Fact]
    public void CanValidateMarkup()
    {
        var cut = RenderComponent<Greeting>();

        // Snapshot-like assertion
        cut.Find("h1").MarkupMatches(@"
<h1 class=""greeting"">
  Hello World!
</h1>");
    }

    [Fact]
    public void CanFindByLabelAssociation()
    {
        var cut = RenderComponent<Greeting>();

        // Query by label's for attribute
        var label = cut.Find("label[for='editbox']");
        Assert.Equal("Name:", label.TextContent);
        
        // Find associated input
        var input = cut.Find("#editbox");
        Assert.NotNull(input);
    }
}