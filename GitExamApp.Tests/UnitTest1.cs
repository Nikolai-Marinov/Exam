using Xunit;
using GitExamApp;

public class AuthTests
{
    [Fact]
    public void Login_ReturnsExpectedString()
    {
        var auth = new Auth();
        var result = auth.Login();
        Assert.Equal("auth logic", result);
    }
}
