using System;

namespace MSS_key_generator.Backend;

public class Value : IHexConvertable
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
}