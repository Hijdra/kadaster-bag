using ConsoleTables;
using System.CommandLine;
using System.CommandLine.IO;
using System.Reflection;

namespace Hya.Kadaster.Bag.Tool.Writers;

public class TableWriter : IOutputWriter
{
    public string Type => "table";

    public void Write<T>(IConsole console, T value)
    {
        if (value is IEnumerable<object> list)
        {
            var type = value.GetType().GetTypeInfo();
            var baseType = (type.IsArray ? type.GetElementType() : type.GenericTypeArguments[0])
                           ?? throw new NotSupportedException("Should not happen");

            var columns = baseType
                .GetProperties()
                .Where(x => x.CanRead)
                .Select(x => x.Name)
                .ToArray();

            var table = new ConsoleTable(columns);
            foreach (var item in list)
            {
                var itemType = item.GetType();
                var row = columns
                    .Select(x => itemType.GetProperty(x)?.GetValue(item))
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
                .Select(x => itemType.GetProperty(x)?.GetValue(value))
                .ToArray();
            table.AddRow(row);

            var output = table.ToMarkDownString();
            console.Out.WriteLine(output);
        }
    }
}