namespace MSS_key_generator.Backend.Concrete;

public class FileNameTag : TagLengthValue
{
    public FileNameTag(byte first, byte second) : base(0x83, new[] { first, second })
    {
    }
}