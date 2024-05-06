namespace CSharpRepeatingWords.Tests;

public class RepeatingWordsTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        Assert.That(Program.GetHighestRepeatingWord("asdf gfhdfh asdf"), Is.EqualTo("asdf"));
    }
    [Test]
    public void Test1Point1()
    {
        Assert.That(Program.GetHighestRepeatingWord("asdf asdf Asdf Asdf gfhdfh gfhdfh gfhdfh"), Is.EqualTo("asdf"));
    }
    [Test]
    public void Test2()
    {
        string phrase = "Lorem ipsum is a random uncited language. Use Lorem";
        Assert.That(Program.GetHighestRepeatingWord(phrase), Is.EqualTo("lorem"));
    }
    [Test]
    public void Test3()
    {
        string phrase = "Penguins live as a happy penguins family in penguins land";
        Assert.That(Program.GetHighestRepeatingWord(phrase), Is.EqualTo("penguins"));
    }
    [Test]
    public void Test4()
    {
        string phrase = "Students used to use notebooks to take notes. Those were old school Students! Students now use laptops.";
        Assert.That(Program.GetHighestRepeatingWord(phrase), Is.EqualTo("students"));
    }
    [Test]
    public void Test5()
    {
        // test multiline string with \n
        string phrase = "Students notebooks take notes. Those were old school Students\n Students use laptops.\n Those were old school Students\n Students use laptops. laptops laptops";
        Assert.That(Program.GetHighestRepeatingWord(phrase), Is.EqualTo("students"));

    }
    [Test]
    public void Test6()
    {
        // test multiline string with \n
        string phrase = "students students students the the the the";
        Assert.That(Program.GetHighestRepeatingWord(phrase), Is.EqualTo("students"));

    }

}
