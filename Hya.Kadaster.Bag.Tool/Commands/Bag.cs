using System.CommandLine;

namespace Hya.Kadaster.Bag.Tool.Commands;

public class Bag : RootCommand
{
    public Bag() : base("Cli tool for querying data from Kadaster Bag API")
    {
        AddCommand(new Auth());
        AddCommand(new AddressFind());
        AddCommand(new AddressGet());
    }

    public override string Name => "bag";
}