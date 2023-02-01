namespace TestProject1;

public class CommonTests
{
    [Test]
    public void UintAndFourBytes_ToHexString_Same()
    {
        var bytes = new byte[] { 255, 255, 255, 255 };
        const uint len = uint.MaxValue;

        var hexInt = len.ToString("X2");
        var hexBytes = Convert.ToHexString(bytes);

        Assert.That(hexBytes, Is.EqualTo(hexInt));
    }

    [Test]
    public void ToHex_int1_01()
    {
        const string hexExpected = "01";
        const int i = 1;

        var hexActual = i.ToString("X2");

        Assert.That(hexActual, Is.EqualTo(hexExpected));
    }
}