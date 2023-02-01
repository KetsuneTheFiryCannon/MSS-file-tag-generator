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

    [Test]
    public void TagValueComputeLength_TV0x8042_2()
    {
        const int expectedLength = 2;
        const byte tagByte = 0x80;
        const byte valueByte = 0x42;

        var tagValue = new TagValue(tagByte, new[] { valueByte });
        var computedLength = tagValue.ComputeLength();

        Assert.That(computedLength, Is.EqualTo(expectedLength));
    }

    [Test]
    public void TagValueComputeLength_TV0x80TV0x8142_2()
    {
        const int expectedLength = 3;
        const byte tagByte = 0x80;
        const byte innerTagByte = 0x81;
        const byte valueByte = 0x11;

        var innerTagValue = new TagValue(innerTagByte, new[] { valueByte });
        var tagValue = new TagValue(tagByte, innerTagValue);
        var computedLength = tagValue.ComputeLength();

        Assert.That(computedLength, Is.EqualTo(expectedLength));
    }
}