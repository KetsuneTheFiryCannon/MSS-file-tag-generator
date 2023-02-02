namespace MSS_key_generator.Backend.Concrete;

public class FileNameTag : TagLengthValue
{
    private FileNameTag(byte first, byte second) : base(0x83, new[] { first, second })
    {
    }

    public FileNameTag(char first, char second) : this((byte)first, (byte)second)
    {
    }
}