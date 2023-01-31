using MSS_key_generator.Backend;

namespace TestProject1;

public class TagValueTests
{
    [Test]
    public void TagValueToHex_0x80010a_80010a()
    {
        const byte tag = 0x80;
        var value = new byte[] { 0x01, 0x0a };
        const string dataHex = "80010A";

        var tagValue = new TagValue(tag, value);
        var hexValue = tagValue.ToHex();

        Assert.That(hexValue, Is.EqualTo(dataHex));
    }
    
    [Test]
    public void TagValueToHex_0x80TV82010a_80010a()
    {
        const byte tag = 0x80;
        var value = new TagValue(0x82, new byte[] { 0x01, 0x0a });
        const string dataHex = "8082010A";

        var tagValue = new TagValue(tag, value);
        var hexValue = tagValue.ToHex();

        Assert.That(hexValue, Is.EqualTo(dataHex));
    }
}