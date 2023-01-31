namespace MSS_key_generator.Backend;

public class TagValue : IHexConvertable
{
    public TagValue(byte tag, byte[] value)
    {
        Tag = tag;
        Value = new Value(value);
    }

    public TagValue(byte tag, TagValue value)
    {
        Tag = tag;
        Value = new Value(value);
    }

    public byte Tag { get; }

    public Value Value { get; }

    public virtual string ToHex()
    {
        var hexTag = Tag.ToString("X2");
        var hexValue = Value.ToHex();
        var hexString = string.Concat(hexTag, hexValue);
        return hexString;
    }
}