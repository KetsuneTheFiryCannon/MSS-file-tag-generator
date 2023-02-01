using MSS_key_generator.Backend;

namespace TestProject1;

public class TagLengthValueTests
{
    [Test]
    public void ToHex_Tag0x80Value0x42_800142()
    {
        const string expectedHex = "800142";
        const byte tagByte = 0x80;
        const byte valueByte = 0x42;

        var tagLengthValue = new TagLengthValue(tagByte, new[] { valueByte });
        var actualHex = tagLengthValue.ToHex();

        Assert.That(actualHex, Is.EqualTo(expectedHex));
    }

    [Test]
    public void ToHex_Tag0x80ValueTV0x4221_80024221()
    {
        const string expectedHex = "80024221";
        const byte tagByte = 0x80;
        const byte innerTagByte = 0x42;
        const byte innerValueByte = 0x21;

        var innerTagValue = new TagValue(innerTagByte, new[] { innerValueByte });
        var tagLengthValue = new TagLengthValue(tagByte, innerTagValue);
        var actualHex = tagLengthValue.ToHex();

        Assert.That(actualHex, Is.EqualTo(expectedHex));
    }

    [Test]
    public void ToHex_Tag0x80ValueTLV0x4221_8003420121()
    {
        const string expectedHex = "8003420121";
        const byte tagByte = 0x80;
        const byte innerTagByte = 0x42;
        const byte innerValueByte = 0x21;

        var innerTagLengthValue = new TagLengthValue(innerTagByte, new[] { innerValueByte });
        var tagLengthValue = new TagLengthValue(tagByte, innerTagLengthValue);
        var actualHex = tagLengthValue.ToHex();

        Assert.That(actualHex, Is.EqualTo(expectedHex));
    }

    [Test]
    public void ToHex_Tag0x80ValueArrayTLV_800870021001021aa1()
    {
        const string expectedHex = "80087002100180021AA1";
        const byte tagByte = 0x80;
        var innerTlv1 = new TagLengthValue(0x70, new byte[] { 0x10, 0x01 });
        var innerTlv2 = new TagLengthValue(0x80, new byte[] { 0x1a, 0xa1 });

        var tagLengthValue = new TagLengthValue(tagByte, new TagValue[] { innerTlv1, innerTlv2 });
        var actualHex = tagLengthValue.ToHex();

        Assert.That(actualHex, Is.EqualTo(expectedHex));
    }

    [Test]
    public void Length_Tag0x80Value0x42_1()
    {
        const int expectedValueLength = 1;
        const byte tagByte = 0x80;
        const byte valueByte = 0x42;

        var tagLengthValue = new TagLengthValue(tagByte, new[] { valueByte });
        var actualLength = tagLengthValue.Length;

        Assert.That(actualLength, Is.EqualTo(expectedValueLength));
    }

    [Test]
    public void Length_Tag0x80ValueTV0x4221_2()
    {
        const int expectedValueLength = 2;
        const byte tagByte = 0x80;
        const byte innerTagByte = 0x42;
        const byte innerValueByte = 0x21;

        var innerTagValue = new TagValue(innerTagByte, new[] { innerValueByte });
        var tagLengthValue = new TagLengthValue(tagByte, innerTagValue);
        var actualLength = tagLengthValue.Length;

        Assert.That(actualLength, Is.EqualTo(expectedValueLength));
    }

    [Test]
    public void Length_Tag0x80ValueTLV0x4221_3()
    {
        const int expectedValueLength = 3;
        const byte tagByte = 0x80;
        const byte innerTagByte = 0x42;
        const byte innerValueByte = 0x21;

        var innerTagLengthValue = new TagLengthValue(innerTagByte, new[] { innerValueByte });
        var tagLengthValue = new TagLengthValue(tagByte, innerTagLengthValue);
        var actualLength = tagLengthValue.Length;

        Assert.That(actualLength, Is.EqualTo(expectedValueLength));
    }

    [Test]
    public void Length_Tag0x80ValueArrayTLV_8()
    {
        const int expectedLength = 8;
        const byte tagByte = 0x80;
        var innerTlv1 = new TagLengthValue(0x70, new byte[] { 0x10, 0x01 });
        var innerTlv2 = new TagLengthValue(0x80, new byte[] { 0x1a, 0xa1 });

        var tagLengthValue = new TagLengthValue(tagByte, new TagValue[] { innerTlv1, innerTlv2 });
        var actualLength = tagLengthValue.Length;

        Assert.That(actualLength, Is.EqualTo(expectedLength));
    }

    [Test]
    public void ComputeLength_Tag0x80Value0x42_3()
    {
        const int expectedValueLength = 3;
        const byte tagByte = 0x80;
        const byte valueByte = 0x42;

        var tagLengthValue = new TagLengthValue(tagByte, new[] { valueByte });
        var actualLength = tagLengthValue.ComputeLength();

        Assert.That(actualLength, Is.EqualTo(expectedValueLength));
    }

    [Test]
    public void ComputeLength_Tag0x80ValueTV0x4221_4()
    {
        const int expectedValueLength = 4;
        const byte tagByte = 0x80;
        const byte innerTagByte = 0x42;
        const byte innerValueByte = 0x21;

        var innerTagValue = new TagValue(innerTagByte, new[] { innerValueByte });
        var tagLengthValue = new TagLengthValue(tagByte, innerTagValue);
        var actualLength = tagLengthValue.ComputeLength();

        Assert.That(actualLength, Is.EqualTo(expectedValueLength));
    }

    [Test]
    public void ComputeLength_Tag0x80ValueTLV0x4221_5()
    {
        const int expectedValueLength = 5;
        const byte tagByte = 0x80;
        const byte innerTagByte = 0x42;
        const byte innerValueByte = 0x21;

        var innerTagLengthValue = new TagLengthValue(innerTagByte, new[] { innerValueByte });
        var tagLengthValue = new TagLengthValue(tagByte, innerTagLengthValue);
        var actualLength = tagLengthValue.ComputeLength();

        Assert.That(actualLength, Is.EqualTo(expectedValueLength));
    }

    [Test]
    public void ComputeLength_Tag0x80ValueArrayTLV_10()
    {
        const int expectedValueLength = 10;
        const byte tagByte = 0x80;
        var innerTlv1 = new TagLengthValue(0x70, new byte[] { 0x10, 0x01 });
        var innerTlv2 = new TagLengthValue(0x80, new byte[] { 0x1a, 0xa1 });

        var tagLengthValue = new TagLengthValue(tagByte, new TagValue[] { innerTlv1, innerTlv2 });
        var actualLength = tagLengthValue.ComputeLength();

        Assert.That(actualLength, Is.EqualTo(expectedValueLength));
    }
}