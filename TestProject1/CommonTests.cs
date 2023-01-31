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
}