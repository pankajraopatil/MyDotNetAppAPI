using Xunit;

namespace MyDotNetApp.Tests;

public class SimpleTest
{
    [Fact]
    public void Test_AlwaysPasses()
    {
        // Arrange
        bool result = true;

        // Assert
        Assert.True(result, "This test should always pass!");
    }

    [Fact]
    public void Test_StringIsNotNull()
    {
        // Arrange
        string message = "Hello CI/CD!";

        // Assert
        Assert.NotNull(message);
    }
}