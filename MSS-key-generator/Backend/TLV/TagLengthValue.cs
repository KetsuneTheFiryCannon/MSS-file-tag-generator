using System;

namespace MSS_key_generator.Backend.TLV;

public class TagLengthValue : TagValue
{
    public TagLengthValue(byte tag, byte[] length, byte[] value) : base(tag, value)
    {
        Length = length;
    }

    public TagLengthValue(byte tag, byte[] length, TagValue value) : base(tag, value)
    {
        Length = length;
    }

    public byte[] Length { get; }

    public override string ToHex()
    {
        var hexTag = Tag.ToString("X2");
        var hexLength = Convert.ToHexString(Length);
        var hexValue = Value.ToHex();
        var hexString = string.Concat(hexTag, hexLength, hexValue);
        return hexString;
    }
}