namespace MSS_key_generator.Backend.Concrete;

public class FileTypeTag : TagLengthValue
{
    public FileTypeTag(FileType fileType) : base(0x82, new[] { (byte)fileType })
    {
    }
}