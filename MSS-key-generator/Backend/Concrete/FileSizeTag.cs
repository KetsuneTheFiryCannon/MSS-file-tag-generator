namespace MSS_key_generator.Backend.Concrete;

public class FileSizeTag : TagLengthValue
{
    public FileSizeTag(int size) : base(0x80, size.ToBytes())
    {
    }
}