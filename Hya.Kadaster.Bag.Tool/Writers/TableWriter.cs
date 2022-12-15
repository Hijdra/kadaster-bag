using System.CommandLine;
using System.CommandLine.IO;
using System.Reflection;
using ConsoleTables;

namespace Hya.Kadaster.Bag.Tool.Writers;

public class TableWriter : IOutputWriter
{
    public string Type => "table";

    public void Write<T>(IConsole console, T value)
    {
        if (value is IEnumerable<object> list)
        {
            var columns = value
                .GetType()
                .GetTypeInfo()
                .GenericTypeArguments[0]
                .GetProperties()
                .Where(x => x.CanRead)
                .Select(x => x.Name)
                .ToArray();

            var table = new ConsoleTable(columns);
            foreach (var item in list)
            {
                var itemType = item.GetType();
                var row = columns
                    .Select(x => itemType.GetProperty(x)?.GetValue(item) ?? new object())
                    .ToArray();
                table.AddRow(row);
            }

            var output = table.ToMarkDownString();
            console.Out.WriteLine(output);
        }
        else
        {
            var columns = value
                .GetType()
                .GetProperties()
                .Where(x => x.CanRead)
                .Select(x => x.Name)
                .ToArray();

            var table = new ConsoleTable(columns);
            
            var itemType = value.GetType();
            var row = columns
                .Select(x => itemType.GetProperty(x)?.GetValue(value) ?? new object())
                .ToArray();
            table.AddRow(row);

            var output = table.ToMarkDownString();
            console.Out.WriteLine(output);
        }
    }
}