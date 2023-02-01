namespace MSS_key_generator.Backend.Concrete;

public class FcpDataTag : TagLengthValue
{
    public FcpDataTag(TagValue[] value) : base(0x62, value)
    {
    }
}