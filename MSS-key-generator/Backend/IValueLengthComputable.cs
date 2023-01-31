namespace MSS_key_generator.Backend;

public interface IValueLengthComputable
{
    /// <summary>
    /// Counts 'Length' of the 'Value' in TLV-data
    /// </summary>
    /// <returns>Length in Int32</returns>
    int ComputeLength();
}