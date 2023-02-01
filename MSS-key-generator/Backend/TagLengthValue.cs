namespace MSS_key_generator.Backend;

public class TagLengthValue : TagValue
{
    public TagLengthValue(byte tag, byte[] value) : base(tag, value)
    {
    }

    public TagLengthValue(byte tag, TagValue value) : base(tag, value)
    {
    }

    public TagLengthValue(byte tag, TagValue[] value) : base(tag, value)
    {
    }

    public int Length => Value.ComputeLength();

    public override string ToHex()
    {
        var hexTag = Tag.ToString("X2");
        var hexLength = Length.ToString("X2");
        var hexValue = Value.ToHex();
        var hexString = string.Concat(hexTag, hexLength, hexValue);
        return hexString;
    }

    public override int ComputeLength()
    {
        return Length + 2;
    }
}