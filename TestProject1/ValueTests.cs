using MSS_key_generator.Backend;

namespace TestProject1;

public class ValueTests
{
    [Test]
    public void ToHex_0x00_00()
    {
        const byte dataByte = 0x00;
        const string dataHex = "00";

        var value = new Value(new[] { dataByte });
        var hexValue = value.ToHex();

        Assert.That(hexValue, Is.EqualTo(dataHex));
    }

    [Test]
    public void ToHex_0xFA_FA()
    {
        const byte dataByte = 0xFA;
        const string dataHex = "FA";

        var value = new Value(new[] { dataByte });
        var hexValue = value.ToHex();

        Assert.That(hexValue, Is.EqualTo(dataHex));
    }

    [Test]
    public void ToHex_72_48()
    {
        const byte dataByte = 72;
        const string dataHex = "48";

        var value = new Value(new[] { dataByte });
        var hexValue = value.ToHex();

        Assert.That(hexValue, Is.EqualTo(dataHex));
    }

    [Test]
    public void ComputeLength_0x42_1()
    {
        const int expectedLength = 1;
        const byte dataByte = 0x42;

        var value = new Value(new[] { dataByte });
        var computedLength = value.ComputeLength();

        Assert.That(computedLength, Is.EqualTo(expectedLength));
    }

    [Test]
    public void ComputeLength_0x422113_3()
    {
        const int expectedLength = 3;
        var dataBytes = new byte[] {0x42, 0x21, 0x13};

        var value = new Value(dataBytes);
        var computedLength = value.ComputeLength();

        Assert.That(computedLength, Is.EqualTo(expectedLength));
    }
}