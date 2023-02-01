using MSS_key_generator.Backend;
using MSS_key_generator.Backend.TLV;

namespace TestProject1;

public class TagLengthValueTests
{
    [Test]
    public void TagLengthValueLength_Tag0x80Value0x42_1()
    {
        const int expectedValueLength = 1;
        const byte tagByte = 0x80;
        const byte valueByte = 0x42;

        var tagLengthValue = new TagLengthValue(tagByte, new[] { valueByte });
        var actualLength = tagLengthValue.Length;
        
        Assert.That(actualLength, Is.EqualTo(expectedValueLength));
    }
    
    [Test]
    public void TagLengthValueLength_Tag0x80ValueTV0x4221_2()
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
    public void TagLengthValueLength_Tag0x80ValueTLV0x4221_3()
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
    public void TagLengthValueComputeLength_Tag0x80Value0x42_3()
    {
        const int expectedValueLength = 3;
        const byte tagByte = 0x80;
        const byte valueByte = 0x42;

        var tagLengthValue = new TagLengthValue(tagByte, new[] { valueByte });
        var actualLength = tagLengthValue.ComputeLength();
        
        Assert.That(actualLength, Is.EqualTo(expectedValueLength));
    }
    
    [Test]
    public void TagLengthValueComputeLength_Tag0x80ValueTV0x4221_4()
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
    public void TagLengthValueComputeLength_Tag0x80ValueTLV0x4221_5()
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
}