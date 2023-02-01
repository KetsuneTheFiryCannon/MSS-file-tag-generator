using System;

namespace MSS_key_generator.Backend;

public class Value : IHexConvertable, IValueLengthComputable
{
    public Value(byte[] byteContent)
    {
        ByteContent = byteContent;
    }

    public Value(TagValue tagContent)
    {
        TagContent = tagContent;
    }

    public byte[]? ByteContent { get; }
    public TagValue? TagContent { get; }

    public bool IsNested => TagContent is { };

    public string ToHex()
    {
        var hexString = IsNested
            ? TagContent!.ToHex()
            : Convert.ToHexString(ByteContent!);

        return hexString;
    }

    public int ComputeLength()
    {
        var computedLength = IsNested
            ? TagContent!.ComputeLength()
            : ByteContent!.Length;
        return computedLength;
    }
}