namespace MSS_key_generator.Backend;

public class ApduCommand : IHexConvertable
{
    public ApduCommand(byte claByte, byte insByte, byte p1Byte, byte p2Byte, TagValue data)
    {
        ClaByte = claByte;
        InsByte = insByte;
        P1Byte = p1Byte;
        P2Byte = p2Byte;
        Data = data;
    }

    public byte ClaByte { get; }
    public byte InsByte { get; }
    public byte P1Byte { get; }
    public byte P2Byte { get; }

    public TagValue Data { get; }

    public int Length => Data.ComputeLength();


    public string ToHex()
    {
        var hexArray = new[]
        {
            ClaByte.Hex(),
            InsByte.Hex(),
            P1Byte.Hex(),
            P2Byte.Hex(),
            Length.Hex(),
            Data.ToHex()
        };
        var hex = string.Join(string.Empty, hexArray);
        return hex;
    }
}