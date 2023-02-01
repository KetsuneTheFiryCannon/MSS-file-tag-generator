using System;

namespace MSS_key_generator.Backend;

public static class IntToByteExtensions
{
    public static byte[] ToBytes(this int i)
    {
        var bytes = BitConverter.GetBytes(i);
        if (BitConverter.IsLittleEndian) Array.Reverse(bytes);
        return bytes;
    }
}