namespace MSS_key_generator.Backend.Concrete;

public class AccessRuleTag : TagLengthValue
{
    public AccessRuleTag(byte[] value) : base(0x86, value)
    {
    }
}