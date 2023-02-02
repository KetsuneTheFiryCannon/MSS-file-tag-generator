using System.Linq;

namespace MSS_key_generator.Backend;

public static class IntToByteExtensions
{
    public static byte[] ToBytes(this int number)
    {
        var bytes = BitConverter.GetBytes(number);
        if (BitConverter.IsLittleEndian) Array.Reverse(bytes);

        var lastZero = 0;
        foreach (var b in bytes)
        {
            if (b == 0) lastZero++;
            else break;
        }

        return bytes.Skip(lastZero).ToArray();
    }
}