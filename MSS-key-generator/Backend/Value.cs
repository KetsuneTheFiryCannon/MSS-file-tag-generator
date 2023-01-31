namespace MSS_key_generator.Backend;

public class Value
{
    public bool IsNested => TagContent is { };
    
    public string? HexContent { get; }
    public TagValue? TagContent { get; }
}