using System.CommandLine;

namespace Hya.Kadaster.Bag.Console.Commands;

public class Bag : RootCommand
{
    public Bag() : base("dotnet run bag -h")
    {
        AddCommand(new AddressFind());
        AddCommand(new AddressGet());
    }
}