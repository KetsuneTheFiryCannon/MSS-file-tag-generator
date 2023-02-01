namespace MSS_key_generator.Backend.Concrete;

public class CreateFileCommand : ApduCommand
{
    public CreateFileCommand(TagValue data)
        : base(0x00, 0xe0, 0x00, 0x00, data)
    {
    }
}