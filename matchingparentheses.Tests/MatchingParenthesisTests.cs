
namespace csharpmatchingparentheses.Tests;

public class MatchingParenthesisTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        Assert.That(Program.DoParenthesisMatch("()"), Is.True);
    }

    [Test]
    public void Test2()
    {
        Assert.That(Program.DoParenthesisMatch("())"), Is.False);
    }
    [Test]
    public void Test3()
    {
        Assert.That(Program.DoParenthesisMatch("[()]"), Is.True);
    }
    [Test]
    public void Test4()
    {
        Assert.That(Program.DoParenthesisMatch("[(])"), Is.False);
    }
}