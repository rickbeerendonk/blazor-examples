// European Union Public License version 1.2
// Copyright © 2023 Rick Beerendonk

using Test_Setup;

namespace Test_Setup_Tests;

// See more: https://bunit.dev/docs/getting-started/writing-tests.html#creating-basic-tests-in-razor-files
public class AppCSsharpTests : TestContext
{
    [Fact]
    public void ShouldRenderHelloBlazor()
    {
        // Arrange
        var cut = RenderComponent<App>();

        // Act

        // Assert
        cut.Find("h1").MarkupMatches("<h1>Hello Blazor!</h1>");
    }
}