using System.CommandLine;

namespace Hya.Kadaster.Bag.Tool.Writers;

public interface IOutputWriter
{
    public string Type { get; }
    public void Write<T>(IConsole console, T value);
}