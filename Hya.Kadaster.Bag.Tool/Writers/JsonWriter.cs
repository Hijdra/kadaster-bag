using System.CommandLine;
using System.CommandLine.IO;
using System.Text.Json;

namespace Hya.Kadaster.Bag.Tool.Writers;

public class JsonWriter : IOutputWriter
{
    public string Type => "json";
    
    public void Write<T>(IConsole console, T value)
    {
        console.Out.WriteLine(JsonSerializer.Serialize(value, new JsonSerializerOptions
        {
            WriteIndented = true
        }));
    }
}