using Hya.Kadaster.Bag.Tool.Writers;
using System.CommandLine;

namespace Hya.Kadaster.Bag.Tool.Commands;

public class OutputHandler
{
    private const string DefaultOutputWriter = "json";
    public string Output { get; set; } = DefaultOutputWriter; // From DI

    private readonly IOutputWriter[] _writers;
    private readonly IOutputWriter _defaultWriter;

    protected OutputHandler(IEnumerable<IOutputWriter> writers)
    {
        _writers = writers.ToArray();
        _defaultWriter = _writers.Single(x => x.Type == DefaultOutputWriter);
    }

    protected void Write<T>(IConsole console, T value)
    {
        var writer = _writers.FirstOrDefault(x => x.Type == Output)
                     ?? _defaultWriter;

        writer.Write(console, value);
    }
}