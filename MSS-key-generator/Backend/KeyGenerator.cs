namespace MSS_key_generator.Backend;

public class KeyGenerator
{
    public GenerationData GenerateCreateFile(string name, FileType fileType, int size)
    {
        if (name is not [var first, var second])
            throw new InvalidOperationException("Name should be two characters' length");

        var command = new CreateFileCommand(
            new FcpDataTag(new TagValue[]
            {
                new FileTypeTag(fileType),
                new FileNameTag(first, second),
                new FileSizeTag(size),
                // TODO: access rule by file types - new AccessRuleTag(new byte[] { 0 })
            })
        );
        return new GenerationData(command);
    }
}