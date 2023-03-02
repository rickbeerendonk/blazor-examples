// European Union Public License version 1.2
// Copyright © 2023 Rick Beerendonk

using Test_Basic;

namespace Test_Basic_Tests;

/// <summary>
/// These tests are written entirely in C#.
/// Learn more at https://bunit.dev/docs/getting-started/writing-tests.html#creating-basic-tests-in-cs-files
/// </summary>
public class AppCSsharpTests : TestContext
{
    [Fact]
    public void ShouldRenderHelloBlazor()
    {
        // Arrange
        var cut = RenderComponent<App>();

        // Assert that content of the paragraph shows counter at zero
        cut.Find("h1").MarkupMatches("<h1>Hello Blazor!</h1>");
    }
}