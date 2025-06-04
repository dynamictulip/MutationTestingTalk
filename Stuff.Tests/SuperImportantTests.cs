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
    public void Test_IsLessThanFortyTwo_is_true_when_less()
    {
        Assert.True(SuperImportant.IsLessThanFortyTwo(10));
    }

    [Fact]
    public void Test_IsLessThanFortyTwo_is_false_when_more()
    {
        Assert.False(SuperImportant.IsLessThanFortyTwo(100000));
    }
}
