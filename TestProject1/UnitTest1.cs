using MSS_key_generator;

namespace TestProject1;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        KeyGenerator keyGenerator = new KeyGenerator();
        string actual = keyGenerator.generateCreateKey("010a", "0101", "000000000000");

        Assert.AreEqual("00e0000014621280010a820101830201018606000000000000", actual);
    }
}