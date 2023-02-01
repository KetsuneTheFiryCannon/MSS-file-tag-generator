namespace MSS_key_generator.Backend;

public static class HexExtensions
{
    public static string Hex(this byte b) => b.ToString("X2");
    public static string Hex(this int i) => i.ToString("X2");
}