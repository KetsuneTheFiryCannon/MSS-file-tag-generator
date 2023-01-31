using MSS_key_generator.Backend;

namespace TestProject1;

public class ValueTests
{
    [Test]
    public void ValueToHex_0x00_00()
    {
        const byte dataByte = 0x00;
        const string dataHex = "00";
 
        var value = new Value(new[] { dataByte });
        var hexValue = value.ToHex();
        
        Assert.That(hexValue, Is.EqualTo(dataHex));
    }
    
    [Test]
    public void ValueToHex_0xFA_FA()
    {
        const byte dataByte = 0xFA;
        const string dataHex = "FA";

        var value = new Value(new[] { dataByte });
        var hexValue = value.ToHex();
        
        Assert.That(hexValue, Is.EqualTo(dataHex));
    }
    
    [Test]
    public void ValueToHex_72_48()
    {
        const byte dataByte = 72;
        const string dataHex = "48";

        var value = new Value(new[] { dataByte });
        var hexValue = value.ToHex();
        
        Assert.That(hexValue, Is.EqualTo(dataHex));
    }
}