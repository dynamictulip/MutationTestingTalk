namespace MutationTestingTalk;

public class UnitTest1
{
    [Fact]
    public void Test_that_passes()
    {
        Assert.True(true);
    }

    [Fact]
    public void Test_that_fails()
    {
        Assert.True(false);
    }
}
