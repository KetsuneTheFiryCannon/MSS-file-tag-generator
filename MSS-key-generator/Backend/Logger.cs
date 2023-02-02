namespace MSS_key_generator.Backend;

public class Logger
{
    private const string LogFileName = "log.txt";
    public string LogFilePath { get; }

    public Logger()
    {
        var currentFolder = Directory.GetCurrentDirectory();
        LogFilePath = Path.Combine(currentFolder, LogFileName);
        if (!File.Exists(LogFilePath)) File.Create(LogFilePath);
    }

    public void Log(string text)
    {
        var options = new FileStreamOptions
        {
            Access = FileAccess.Write,
            Mode = FileMode.Append,
            Share = FileShare.Read
        };
        using var stream = new StreamWriter(LogFilePath, Encoding.UTF8, options);
        stream.WriteLine(text);
    }

    public async Task LogAsync(string text)
    {
        var options = new FileStreamOptions
        {
            Access = FileAccess.Write,
            Mode = FileMode.Append,
            Share = FileShare.Read
        };
        await using var stream = new StreamWriter(LogFilePath, Encoding.UTF8, options);
        await stream.WriteLineAsync(text);
    }
}