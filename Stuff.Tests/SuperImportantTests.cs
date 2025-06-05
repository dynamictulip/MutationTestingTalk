namespace MutationTestingTalk;

public class SuperImportantTests
{
    [Fact]
    public void Test_Hello()
    {
        Assert.Equal("Hello", SuperImportant.Hello);
    }

    [Fact]
    public void Test_Add()
    {
        var actual = SuperImportant.Add(2, 2);

        Assert.Equal(4, actual);
    }

    [Fact]
    public void Test_IsGmailAddress()
    {
        var actual = SuperImportant.IsGmailAddress("me@gmail.com");

        Assert.True(actual);
    }

    [Fact]
    public void Test_IsGmailAddress_fails()
    {
        SuperImportant.IsGmailAddress("me@yahoo.com");
    }
}
