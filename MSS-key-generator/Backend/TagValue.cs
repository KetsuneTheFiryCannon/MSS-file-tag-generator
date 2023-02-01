namespace MSS_key_generator.Backend;

public class TagValue : IHexConvertable, IValueLengthComputable
{
    private TagValue(byte tag)
    {
        Tag = tag;
    }

    public TagValue(byte tag, byte[] value) : this(tag)
    {
        Value = new Value(value);
    }

    public TagValue(byte tag, TagValue[] value) : this(tag)
    {
        Value = new Value(value);
    }

    public TagValue(byte tag, TagValue value) : this(tag, new[] { value })
    {
    }

    public byte Tag { get; }

    public Value Value { get; } = null!;

    public virtual string ToHex()
    {
        var hexTag = Tag.ToString("X2");
        var hexValue = Value.ToHex();
        var hexString = string.Concat(hexTag, hexValue);
        return hexString;
    }

    public virtual int ComputeLength()
    {
        return Value.ComputeLength() + 1;
    }
}