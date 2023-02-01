using System;
using System.Linq;

namespace MSS_key_generator.Backend;

public class Value : IHexConvertable, IValueLengthComputable
{
    public Value(byte[] byteContent)
    {
        ByteContent = byteContent;
    }

    public Value(TagValue[] tagContent)
    {
        TagContent = tagContent;
    }

    public byte[]? ByteContent { get; }
    public TagValue[]? TagContent { get; }

    public bool IsNested => TagContent is { };

    public string ToHex()
    {
        if (!IsNested) return Convert.ToHexString(ByteContent!);

        var tagsHexes = TagContent!.Select(value => value.ToHex()).ToArray();
        var valueHex = string.Join(string.Empty, tagsHexes);
        return valueHex;
    }

    public int ComputeLength()
    {
        var computedLength = IsNested
            ? TagContent!.Select(value => value.ComputeLength()).Sum()
            : ByteContent!.Length;
        return computedLength;
    }
}